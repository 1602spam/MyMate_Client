namespace MainForm.Controls
{
    partial class UserChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChat));
            this.button1 = new System.Windows.Forms.Button();
            this.userNameTxt = new System.Windows.Forms.Label();
            this.roundButton1 = new MainForm.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.AutoSize = true;
            this.userNameTxt.Enabled = false;
            this.userNameTxt.Location = new System.Drawing.Point(43, 13);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(67, 15);
            this.userNameTxt.TabIndex = 6;
            this.userNameTxt.Text = "Username1";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.Control;
            this.roundButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton1.BackgroundImage")));
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton1.BorderColor = System.Drawing.Color.Red;
            this.roundButton1.BorderRadius = 15;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(5, 5);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(5);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(30, 30);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // UserChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.button1);
            this.Name = "UserChat";
            this.Size = new System.Drawing.Size(155, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label userNameTxt;
        private RoundButton roundButton1;
    }
}
