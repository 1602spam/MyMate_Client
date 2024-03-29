﻿namespace MainForm.Controls
{
    partial class CheckListPage
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.createProjectBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.CLDoneBox = new System.Windows.Forms.CheckedListBox();
            this.CLBox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMemberList = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(750, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 632);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 582);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.createProjectBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 50);
            this.panel5.TabIndex = 0;
            // 
            // createProjectBtn
            // 
            this.createProjectBtn.Location = new System.Drawing.Point(36, 13);
            this.createProjectBtn.Name = "createProjectBtn";
            this.createProjectBtn.Size = new System.Drawing.Size(139, 23);
            this.createProjectBtn.TabIndex = 0;
            this.createProjectBtn.Text = "프로젝트 추가";
            this.createProjectBtn.UseVisualStyleBackColor = true;
            this.createProjectBtn.Click += new System.EventHandler(this.createProjectBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 632);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.removeBtn);
            this.panel4.Controls.Add(this.editBtn);
            this.panel4.Controls.Add(this.CLDoneBox);
            this.panel4.Controls.Add(this.CLBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lblMemberList);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 582);
            this.panel4.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(693, 11);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(40, 23);
            this.removeBtn.TabIndex = 11;
            this.removeBtn.Text = "삭제";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(647, 11);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(40, 23);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "수정";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // CLDoneBox
            // 
            this.CLDoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLDoneBox.CheckOnClick = true;
            this.CLDoneBox.FormattingEnabled = true;
            this.CLDoneBox.Location = new System.Drawing.Point(23, 352);
            this.CLDoneBox.Name = "CLDoneBox";
            this.CLDoneBox.Size = new System.Drawing.Size(709, 144);
            this.CLDoneBox.TabIndex = 9;
            // 
            // CLBox
            // 
            this.CLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLBox.CheckOnClick = true;
            this.CLBox.FormattingEnabled = true;
            this.CLBox.Location = new System.Drawing.Point(23, 163);
            this.CLBox.Name = "CLBox";
            this.CLBox.Size = new System.Drawing.Size(709, 144);
            this.CLBox.TabIndex = 8;
            this.CLBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBox_ItemCheck);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "< 완료 업무 >";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "< 업무 >";
            // 
            // lblMemberList
            // 
            this.lblMemberList.AutoSize = true;
            this.lblMemberList.Location = new System.Drawing.Point(38, 99);
            this.lblMemberList.Name = "lblMemberList";
            this.lblMemberList.Size = new System.Drawing.Size(43, 15);
            this.lblMemberList.TabIndex = 5;
            this.lblMemberList.Text = "참여자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "< 참여자 >";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(38, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "< 제목/주제 >";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 50);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "0 %";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(674, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // CheckListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckListPage";
            this.Size = new System.Drawing.Size(950, 632);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Button createProjectBtn;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private ProgressBar progressBar1;
        private CheckedListBox CLDoneBox;
        private CheckedListBox CLBox;
        private Label label9;
        private Label label8;
        private Label lblMemberList;
        private Label label6;
        private Label lblTitle;
        private Label label2;
        private Button removeBtn;
        private Button editBtn;
    }
}
