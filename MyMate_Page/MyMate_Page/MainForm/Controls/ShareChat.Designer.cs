namespace MainForm.Controls
{
    partial class ShareChat
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblText.Location = new System.Drawing.Point(13, 8);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(258, 15);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Username123 님이 123123을 공유하였습니다.";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(460, 4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(55, 23);
            this.btnReceive.TabIndex = 1;
            this.btnReceive.Text = "받기";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // ShareChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblText);
            this.Name = "ShareChat";
            this.Size = new System.Drawing.Size(530, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblText;
        private Button btnReceive;
    }
}
