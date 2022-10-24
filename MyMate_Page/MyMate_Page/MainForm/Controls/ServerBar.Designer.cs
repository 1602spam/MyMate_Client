namespace MainForm.Controls
{
    partial class ServerBar
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
            this.profileBtn = new MainForm.Controls.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serverBtn = new MainForm.Controls.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.profileBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.profileBtn.BorderColor = System.Drawing.Color.Red;
            this.profileBtn.BorderRadius = 20;
            this.profileBtn.BorderSize = 0;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Location = new System.Drawing.Point(5, 5);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(5);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(40, 40);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.TextColor = System.Drawing.Color.White;
            this.profileBtn.UseVisualStyleBackColor = false;
            
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.serverBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 450);
            this.panel2.TabIndex = 3;
            
            // 
            // serverBtn
            // 
            this.serverBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.serverBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.serverBtn.BorderColor = System.Drawing.Color.Red;
            this.serverBtn.BorderRadius = 20;
            this.serverBtn.BorderSize = 0;
            this.serverBtn.FlatAppearance.BorderSize = 0;
            this.serverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverBtn.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serverBtn.ForeColor = System.Drawing.Color.White;
            this.serverBtn.Location = new System.Drawing.Point(5, 5);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(40, 40);
            this.serverBtn.TabIndex = 1;
            this.serverBtn.TextColor = System.Drawing.Color.White;
            this.serverBtn.UseVisualStyleBackColor = false;
            // 
            // ServerBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ServerBar";
            this.Size = new System.Drawing.Size(50, 500);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton profileBtn;
        private Panel panel1;
        private Panel panel2;
        private RoundButton serverBtn;
    }
}
