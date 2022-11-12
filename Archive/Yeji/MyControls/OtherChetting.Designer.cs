namespace Yeji.MyControls
{
    partial class OtherChetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherChetting));
            this.Bubble = new Yeji.MyControls.CButton();
            this.ProfileName = new System.Windows.Forms.Label();
            this.MsgDate = new System.Windows.Forms.Label();
            this.ProfileImg = new Yeji.MyControls.CButton();
            this.MsgText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bubble
            // 
            this.Bubble.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bubble.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Bubble.BorderColor = System.Drawing.Color.Red;
            this.Bubble.BorderRadius = 15;
            this.Bubble.BorderSize = 0;
            this.Bubble.Enabled = false;
            this.Bubble.FlatAppearance.BorderSize = 0;
            this.Bubble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bubble.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bubble.ForeColor = System.Drawing.Color.White;
            this.Bubble.Location = new System.Drawing.Point(45, 22);
            this.Bubble.MinimumSize = new System.Drawing.Size(135, 0);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(300, 35);
            this.Bubble.TabIndex = 0;
            this.Bubble.TextColor = System.Drawing.Color.White;
            this.Bubble.UseVisualStyleBackColor = false;
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProfileName.ForeColor = System.Drawing.Color.Black;
            this.ProfileName.Location = new System.Drawing.Point(55, 8);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(51, 13);
            this.ProfileName.TabIndex = 1;
            this.ProfileName.Text = "Goguma";
            // 
            // MsgDate
            // 
            this.MsgDate.AutoSize = true;
            this.MsgDate.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsgDate.Location = new System.Drawing.Point(270, 8);
            this.MsgDate.Name = "MsgDate";
            this.MsgDate.Size = new System.Drawing.Size(59, 13);
            this.MsgDate.TabIndex = 2;
            this.MsgDate.Text = "2022.10.13";
            // 
            // ProfileImg
            // 
            this.ProfileImg.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ProfileImg.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ProfileImg.BorderColor = System.Drawing.Color.Red;
            this.ProfileImg.BorderRadius = 20;
            this.ProfileImg.BorderSize = 0;
            this.ProfileImg.FlatAppearance.BorderSize = 0;
            this.ProfileImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileImg.ForeColor = System.Drawing.Color.White;
            this.ProfileImg.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImg.Image")));
            this.ProfileImg.Location = new System.Drawing.Point(1, 20);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.Size = new System.Drawing.Size(40, 40);
            this.ProfileImg.TabIndex = 3;
            this.ProfileImg.Text = "프로필";
            this.ProfileImg.TextColor = System.Drawing.Color.White;
            this.ProfileImg.UseVisualStyleBackColor = false;
            // 
            // MsgText
            // 
            this.MsgText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgText.AutoSize = true;
            this.MsgText.BackColor = System.Drawing.Color.Transparent;
            this.MsgText.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsgText.Location = new System.Drawing.Point(55, 31);
            this.MsgText.Name = "MsgText";
            this.MsgText.Size = new System.Drawing.Size(43, 17);
            this.MsgText.TabIndex = 4;
            this.MsgText.Text = "label3";
            this.MsgText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OtherChetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.MsgText);
            this.Controls.Add(this.ProfileImg);
            this.Controls.Add(this.MsgDate);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.Bubble);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "OtherChetting";
            this.Size = new System.Drawing.Size(352, 68);
            this.Resize += new System.EventHandler(this.OtherChetting_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CButton Bubble;
        private Label ProfileName;
        private Label MsgDate;
        private CButton ProfileImg;
        private Label MsgText;
    }
}
