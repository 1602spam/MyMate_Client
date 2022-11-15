using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
using ClientModules.Services;
using MainForm.PopupControls;
using Protocol;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class CheckListPage : UserControl
    {
        // 프로젝트, 프로젝트 아이템, 서버
        public MdlProject Project { get; set; }
        public MdlProjectItem ProjectItem { get; set; }
        public MdlServer? Server { get; set; }

        public List<MdlProject> projects = new();
        //오른쪽 바에 넣을 프로젝트 컴포넌트 저장
        public List<CheckListProject> projectcontrols = new List<CheckListProject>();

        public CheckListPage()
        {
            InitializeComponent();

            //페이지 처음 들어갔을 때는 정보 안보이게 함
            this.Visible = false;

            //프로젝트 클릭하거나 생성했을 때부터 보이게 함
            panel4.Visible = false;

            //최초로 들어왔을 시 프로젝트 컨테이너에 있는 내용을 불러와 표시함
            if (ProjectContainer.Instance.Items.Values != null && ProjectContainer.Instance.Items.Values.Count != 0)
            {
                foreach (var item in ProjectContainer.Instance.Items.Values)
                {
                    AddOrUpdateProject(item);
                }
            }
            //프로젝트 컨테이너에 프로젝트 추가/갱신 될 때마다 프로젝트 새로고침
            ProjectContainer.Instance.DataDistributedEvent += AddOrUpdateProject;
        }

        public void ClearProjectItem()
        {
            if (Project != null)
                Project.Items.DataDistributedEvent -= AddOrUpdateProjectItems;
            //프로젝트 정보 나오는 패널 클리어
            panel4.Visible = false;
            CLBox.Items.Clear();      // 아이템 초기화
            CLDoneBox.Items.Clear();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            SvcDistributor.Instance.PutProject(new(this.Project.Code, true));
            ClearProjectItem();
        }

        public void SwitchProject(MdlProject p)
        {
            ClearProjectItem();
            panel4.Visible = true;
            this.Project = p;
            Project.Items.DataDistributedEvent += AddOrUpdateProjectItems;

            lblTitle.Text = p.Title;
            lblMemberList.Text = "";
            this.Server = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == Project.ServerCode);
            if (this.Server == null)
            {
                MessageBox.Show("유효하지 않은 서버 정보입니다.", "알림");
                return;
            }

            foreach (var item in Server.Users)
            {
                MdlUser? user = UserContainer.Instance.Items.Values.FirstOrDefault(MdlUser => MdlUser.Code == item);
                if (user == null)
                {
                    MessageBox.Show("유효하지 않은 유저 정보입니다.", "알림");
                    return;
                }
                else
                {
                    lblMemberList.Text += user.Username + " ";
                }
            }

        }

        private void AddOrUpdateProject(object v)
        {
            //이벤트 인자로 받은 오브젝트가 null이라면 리턴
            if (v == null)
                return;

            //MdlProject로 형변환
            MdlProject? project = v as MdlProject;
            if (project == null)
                return;

            //없으면 그냥 추가하고 리턴
            if (projectcontrols.Count == 0)
            {
                projects.Add(project);
                AddProject(project);
                return;
            }
            else
            {
                MdlProject? temp;
                if (ProjectContainer.Instance.Items.Count > 0)
                {
                    temp = ProjectContainer.Instance.Items.Values.FirstOrDefault(MdlProject => MdlProject.Code == project.Code);
                    if (temp == null)
                    {
                        //동일한 코드의 프로젝트를 가지고 있지 않다면 그냥 추가 후 리턴
                        projects.Add(project);
                        AddProject(project);
                        return;
                    }
                    else
                    {
                        projects.Remove(temp);
                        projects.Add(project);
                        //이미 동일한 코드의 프로젝트가 있다면 컨트롤 삭제 후 추가
                        var item = projectcontrols.FirstOrDefault(CheckListProject => CheckListProject.Project.Code == project.Code);
                        if (item != null)
                        {
                            projectcontrols.Remove(item);
                            panel6.Controls.Remove(item);
                        }
                        AddProject(project);
                    }
                }
                //있으면 기존 프로젝트 중 이미 추가한 프로젝트가 있는지 확인
            }
        }

        private void AddOrUpdateProjectItems(object v)
        {
            //이벤트 인자로 받은 오브젝트가 null이라면 리턴
            if (v == null)
                return;

            //MdlProject로 형변환
            MdlProjectItem? projectitem = v as MdlProjectItem;
            if (projectitem == null)
                return;

            //같은 코드의 아이템을 찾아요
            MdlProjectItem? temp = Project.Items.Items.FirstOrDefault(MdlProjectItem => MdlProjectItem.Code == projectitem.Code);
            if (temp == null)
            {
                //없으면 넣어요
                if (projectitem.IsChecked == true)
                    CLDoneBox.Items.Add(projectitem.Content);
                else
                    CLBox.Items.Add(projectitem.Content);
            }
            else
            {
                //있으면 지우고 넣어요
                //체크 여부가 바뀌었으면 반대쪽에 넣어요
                if (projectitem.IsChecked != temp.IsChecked)
                {
                    //CLDoneBox => CLBox
                    //temp.IsChecked==false
                    if (projectitem.IsChecked == true)
                    {
                        CLBox.Items.Remove(temp.Content);
                        CLDoneBox.Items.Add(projectitem.Content);
                    }
                    else
                    {
                        CLDoneBox.Items.Remove(temp.Content);
                        CLBox.Items.Add(projectitem.Content);
                    }
                }
                else
                {
                    if (projectitem.IsChecked == true)
                        CLDoneBox.Items.Add(projectitem.Content);
                    else
                        CLBox.Items.Add(projectitem.Content);
                }
            }
        }

        private void AddProject(MdlProject v)
        {
            if (v.IsDeleted == true)
                return;

            CheckListProject item = new(v);
            panel6.Controls.Add(item);
            projectcontrols.Add(item);
            item.Dock = DockStyle.Top;
            item.BringToFront();
        }

        //프로젝트 생성 버튼 눌렀을 때
        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            // 팝업 띄움
            CreateProjectPopup createProjectPopup = new CreateProjectPopup();
            createProjectPopup.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            CheckListWorkPopup checkListWorkPopup = new CheckListWorkPopup(Project); //정보넘겨줌
            checkListWorkPopup.ShowDialog();
        }

        private void CLBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //code 검색
            //삭제
            //리셋
        }
    }
}
