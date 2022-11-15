namespace MainForm.Controls
{
    partial class CheckListProject
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.projectBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblProgress);
            this.panel1.Controls.Add(this.lblServer);
            this.panel1.Controls.Add(this.projectBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 150);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(15, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 15);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "제목:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblProgress.Location = new System.Drawing.Point(15, 117);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(85, 15);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "진척도 : 000%";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblServer.Location = new System.Drawing.Point(15, 17);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(114, 15);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "[서버 n의 프로젝트]";
            // 
            // projectBtn
            // 
            this.projectBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.projectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectBtn.FlatAppearance.BorderSize = 0;
            this.projectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectBtn.Location = new System.Drawing.Point(0, 0);
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(180, 150);
            this.projectBtn.TabIndex = 3;
            this.projectBtn.UseVisualStyleBackColor = false;
            this.projectBtn.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // CheckListProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "CheckListProject";
            this.Size = new System.Drawing.Size(180, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblProgress;
        private Label lblServer;
        private Button projectBtn;
        private Label lblTitle;
    }
}
