using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientModules.Containers;
using ClientModules.Models;
using MainForm.PopupControls;

namespace MainForm.Controls
{
    public partial class FriendPage : UserControl
    {
        //친구 데이터를 저장
        List<MdlFriend> friends = new();
        List<FriendPageItem> frienditems = new();
        public FriendPage()
        {
            InitializeComponent();
            //컨테이너의 친구 목록을 가져옴
            friends = FriendContainer.Instance.GetFriends();

            if (friends != null)
            {
                //해당 친구들에 대해 컴포넌트를 생성함
                foreach (var item in friends)
                {
                    AddFriend(item);
                }
            }
            //친구 업데이트 될 때마다 추가 혹은 갱신되도록 이벤트 등록
            FriendContainer.Instance.DataDistributedEvent += AddOrUpdateFriend;
        }

        private void rbtnFindFriend_Click(object sender, EventArgs e)
        {
            //친구 추가 버튼을 누르면 폼을 띄우고, 그 안에서 성공적으로 친구 업데이트하면 자동으로 처리됨
            SearchFriend searchFriend = new SearchFriend();
            searchFriend.ShowDialog();
        }

        private void AddOrUpdateFriend(object f)
        {
            //이벤트 인자로 받은 object f가 null이라면 return
            if (f == null)
                return;

            //object f를 MdlFriend로 형변환한 결과가 null이라면 return
            MdlFriend? friend = f as MdlFriend;
            if (friend == null)
                return;

            //최초 추가 시 비교할 데이터가 없으므로 그냥 리스트와 컨트롤에 추가
            if (friends.Count == 0)
            {
                friends.Add(friend);
                AddFriend(friend);
                return;
            }
            else 
            {
                //기존 데이터 중 코드가 일치하는 데이터가 있는지 찾음
                //데이터가 없다면 temp는 null이므로 AddFriend, 있다면 null이 아니므로 갱신
                var temp = friends.FirstOrDefault(MdlFriend => MdlFriend.FriendCode == friend.FriendCode);
                if (temp == null)
                {
                    friends.Add(friend);
                    AddFriend(friend);
                    return;
                }
                else
                {
                    int i = friends.IndexOf(temp);
                    friends.Insert(i, friend);
                    friends.Remove(temp);
                    var item = frienditems.FirstOrDefault(FriendPageItem => FriendPageItem.friend.FriendCode == friend.FriendCode);
                    if (item != null)
                    {
                        frienditems.Remove(item);
                        panFriends.Controls.Remove(item);
                    }
                    AddFriend(friend);
                }
            }
        }

        private void AddFriend(MdlFriend f)
        {
            int i = 0;
            foreach (var v in friends)
            {
                if (v.IsDeleted == true) { i++; }
            }

            //deleted 속성을 가진 친구 수만큼 제해서 표시
            lblFriendCap.Text = "친구 목록 - " + (friends.Count-i) + "명";
            
            //deleted 속성이 true라면 객체로 추가하지 않음
            if (f.IsDeleted == true) {
                return;
            }
            
            FriendPageItem item = new FriendPageItem(f);
            panFriends.Controls.Add(item);
            frienditems.Add(item);
            item.Dock = DockStyle.Top;
            item.BringToFront();
        }
    }
}
