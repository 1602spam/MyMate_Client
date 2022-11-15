namespace MainForm.PopupControls
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
            this.lblServername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editProjectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTask = new System.Windows.Forms.ListBox();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lblServername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.editProjectBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbProjectName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 370);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblServername
            // 
            this.lblServername.AutoSize = true;
            this.lblServername.Location = new System.Drawing.Point(12, 167);
            this.lblServername.Name = "lblServername";
            this.lblServername.Size = new System.Drawing.Size(70, 15);
            this.lblServername.TabIndex = 26;
            this.lblServername.Text = "Servername";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "대상 서버";
            // 
            // editProjectBtn
            // 
            this.editProjectBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editProjectBtn.FlatAppearance.BorderSize = 0;
            this.editProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProjectBtn.Location = new System.Drawing.Point(107, 322);
            this.editProjectBtn.Name = "editProjectBtn";
            this.editProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.editProjectBtn.TabIndex = 1;
            this.editProjectBtn.Text = "수정";
            this.editProjectBtn.UseVisualStyleBackColor = false;
            this.editProjectBtn.Click += new System.EventHandler(this.editProjectBtn_Click);
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
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "프로젝트 이름";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(12, 87);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(261, 23);
            this.tbProjectName.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.lbTask);
            this.panel2.Controls.Add(this.tbTask);
            this.panel2.Controls.Add(this.btnRemoveTask);
            this.panel2.Controls.Add(this.btnAddTask);
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
            // lbTask
            // 
            this.lbTask.FormattingEnabled = true;
            this.lbTask.ItemHeight = 15;
            this.lbTask.Location = new System.Drawing.Point(41, 87);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(284, 229);
            this.lbTask.TabIndex = 11;
            // 
            // tbTask
            // 
            this.tbTask.Location = new System.Drawing.Point(41, 58);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(284, 23);
            this.tbTask.TabIndex = 10;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveTask.FlatAppearance.BorderSize = 0;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Location = new System.Drawing.Point(250, 322);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTask.TabIndex = 4;
            this.btnRemoveTask.Text = "삭제";
            this.btnRemoveTask.UseVisualStyleBackColor = false;
            this.btnRemoveTask.Click += new System.EventHandler(this.removeWorkBtn_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Location = new System.Drawing.Point(41, 322);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "추가";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.addWorkBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "업무 추가 및 삭제";
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
        private Button btnRemoveTask;
        private Button btnAddTask;
        private Label label2;
        private Label label6;
        private TextBox tbProjectName;
        private TextBox tbTask;
        private Label lblServername;
        private Label label4;
        private ListBox lbTask;
    }
}