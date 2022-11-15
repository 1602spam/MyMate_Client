namespace MainForm.Controls
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.userprofileBtn = new MainForm.Controls.RoundButton();
            this.userNameTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userprofileBtn
            // 
            this.userprofileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.userprofileBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userprofileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userprofileBtn.BackgroundImage")));
            this.userprofileBtn.BorderColor = System.Drawing.Color.Red;
            this.userprofileBtn.BorderRadius = 15;
            this.userprofileBtn.BorderSize = 0;
            this.userprofileBtn.FlatAppearance.BorderSize = 0;
            this.userprofileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userprofileBtn.ForeColor = System.Drawing.Color.White;
            this.userprofileBtn.Location = new System.Drawing.Point(5, 5);
            this.userprofileBtn.Margin = new System.Windows.Forms.Padding(5);
            this.userprofileBtn.Name = "userprofileBtn";
            this.userprofileBtn.Size = new System.Drawing.Size(30, 30);
            this.userprofileBtn.TabIndex = 0;
            this.userprofileBtn.TextColor = System.Drawing.Color.White;
            this.userprofileBtn.UseVisualStyleBackColor = false;
            this.userprofileBtn.Click += new System.EventHandler(this.userprofileBtn_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.AutoSize = true;
            this.userNameTxt.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTxt.Location = new System.Drawing.Point(43, 12);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(43, 17);
            this.userNameTxt.TabIndex = 1;
            this.userNameTxt.Text = "label1";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userprofileBtn);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(144, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton userprofileBtn;
        private Label userNameTxt;
    }
}
