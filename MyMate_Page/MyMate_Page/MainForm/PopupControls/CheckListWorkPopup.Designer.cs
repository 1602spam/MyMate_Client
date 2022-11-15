﻿namespace MainForm.PopupControls
{
    partial class CheckListWorkPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDayTxt = new System.Windows.Forms.TextBox();
            this.editProjectBtn = new System.Windows.Forms.Button();
            this.startDayTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.projectNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workListBox = new System.Windows.Forms.ListBox();
            this.workTxt = new System.Windows.Forms.TextBox();
            this.removeWorkBtn = new System.Windows.Forms.Button();
            this.addWorkBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.endDayTxt);
            this.panel1.Controls.Add(this.editProjectBtn);
            this.panel1.Controls.Add(this.startDayTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.projectNameTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 370);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "대상 서버";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "~";
            // 
            // endDayTxt
            // 
            this.endDayTxt.Location = new System.Drawing.Point(139, 238);
            this.endDayTxt.Name = "endDayTxt";
            this.endDayTxt.Size = new System.Drawing.Size(100, 23);
            this.endDayTxt.TabIndex = 23;
            // 
            // editProjectBtn
            // 
            this.editProjectBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editProjectBtn.FlatAppearance.BorderSize = 0;
            this.editProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProjectBtn.Location = new System.Drawing.Point(89, 302);
            this.editProjectBtn.Name = "editProjectBtn";
            this.editProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.editProjectBtn.TabIndex = 1;
            this.editProjectBtn.Text = "수정";
            this.editProjectBtn.UseVisualStyleBackColor = false;
            this.editProjectBtn.Click += new System.EventHandler(this.editProjectBtn_Click);
            // 
            // startDayTxt
            // 
            this.startDayTxt.Location = new System.Drawing.Point(12, 238);
            this.startDayTxt.Name = "startDayTxt";
            this.startDayTxt.Size = new System.Drawing.Size(100, 23);
            this.startDayTxt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "프로젝트 수정 및 삭제";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "프로젝트 이름";
            // 
            // projectNameTxt
            // 
            this.projectNameTxt.Location = new System.Drawing.Point(12, 96);
            this.projectNameTxt.Name = "projectNameTxt";
            this.projectNameTxt.Size = new System.Drawing.Size(261, 23);
            this.projectNameTxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "기간 ( yyyy-mm-dd )";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.workListBox);
            this.panel2.Controls.Add(this.workTxt);
            this.panel2.Controls.Add(this.removeWorkBtn);
            this.panel2.Controls.Add(this.addWorkBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(288, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 370);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // workListBox
            // 
            this.workListBox.FormattingEnabled = true;
            this.workListBox.ItemHeight = 15;
            this.workListBox.Location = new System.Drawing.Point(41, 96);
            this.workListBox.Name = "workListBox";
            this.workListBox.Size = new System.Drawing.Size(284, 229);
            this.workListBox.TabIndex = 11;
            // 
            // workTxt
            // 
            this.workTxt.Location = new System.Drawing.Point(41, 58);
            this.workTxt.Name = "workTxt";
            this.workTxt.Size = new System.Drawing.Size(203, 23);
            this.workTxt.TabIndex = 10;
            // 
            // removeWorkBtn
            // 
            this.removeWorkBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeWorkBtn.FlatAppearance.BorderSize = 0;
            this.removeWorkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeWorkBtn.Location = new System.Drawing.Point(41, 335);
            this.removeWorkBtn.Name = "removeWorkBtn";
            this.removeWorkBtn.Size = new System.Drawing.Size(75, 23);
            this.removeWorkBtn.TabIndex = 4;
            this.removeWorkBtn.Text = "삭제";
            this.removeWorkBtn.UseVisualStyleBackColor = false;
            this.removeWorkBtn.Click += new System.EventHandler(this.removeWorkBtn_Click);
            // 
            // addWorkBtn
            // 
            this.addWorkBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addWorkBtn.FlatAppearance.BorderSize = 0;
            this.addWorkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkBtn.Location = new System.Drawing.Point(250, 57);
            this.addWorkBtn.Name = "addWorkBtn";
            this.addWorkBtn.Size = new System.Drawing.Size(75, 23);
            this.addWorkBtn.TabIndex = 3;
            this.addWorkBtn.Text = "추가";
            this.addWorkBtn.UseVisualStyleBackColor = false;
            this.addWorkBtn.Click += new System.EventHandler(this.addWorkBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "업무 추가 및 샂제";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(330, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // CheckListWorkPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckListWorkPopup";
            this.Text = "CheckListWorkPopup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button closeBtn;
        private Button editProjectBtn;
        private Label label1;
        private Button removeWorkBtn;
        private Button addWorkBtn;
        private Label label2;
        private Label label5;
        private TextBox endDayTxt;
        private TextBox startDayTxt;
        private Label label6;
        private TextBox projectNameTxt;
        private Label label3;
        private TextBox workTxt;
        private Label label7;
        private Label label4;
        private ListBox workListBox;
    }
}