﻿using ClientModules.Containers;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
using ClientModules.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.PopupControls
{
    public partial class CheckListWorkPopup : Form
    {
        MdlProject Project { get; set; }
        
        private Point mousePoint;

        public CheckListWorkPopup(MdlProject project)
        {
            InitializeComponent();
            //서버코드 CheckListPage로 부터 받아 옴
            Project = project;

            MdlServer server = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == Project.ServerCode);
            if (server == null)
                this.lblServername.Text = "유효하지 않은 서버";
            else
                this.lblServername.Text = server.Title;

            tbProjectName.Text = project.Title;

            //리스트 정보 업데이트
            foreach (var item in Project.Items.Items)
            {
                if (item != null)
                {
                    lbTask.Items.Add(item.Content.ToString());
                }
            }
        }
        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            foreach (string item in lbTask.Items)
            {
                SvcDistributor.Instance.PutProjectItem(new(Project.Items.Items.Count + 1, Project.Code, item, false));
            }
            this.Close();
        }

        private void addWorkBtn_Click(object sender, EventArgs e)
        {
            if (tbTask.Text != "")
            {
                lbTask.Items.Add(tbTask.Text);
            }
            tbTask.Text = "";
        }

        //삭제버튼 눌렷을때
        private void removeWorkBtn_Click(object sender, EventArgs e)
        {
            if (lbTask.SelectedIndex != -1)
            {
                lbTask.Items.Remove(lbTask.SelectedItem);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }



        /* 선택됐는지 조건
         * 선택됐으면 코드 넘겨주기 project 로
         * 돌아오면 새로고침 함수 호출
         */
    }
}
