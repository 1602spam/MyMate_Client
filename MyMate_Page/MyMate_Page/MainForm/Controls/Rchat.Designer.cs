namespace MainForm.Controls
{
    partial class Rchat
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
            this.chatLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.chatBtn = new MainForm.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.chatLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatLabel.Location = new System.Drawing.Point(79, 30);
            this.chatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.chatLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(200, 15);
            this.chatLabel.TabIndex = 8;
            this.chatLabel.Text = "label1";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(335, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Goguma";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(9, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "2022.11.01";
            // 
            // chatBtn
            // 
            this.chatBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.chatBtn.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.chatBtn.BorderColor = System.Drawing.Color.Red;
            this.chatBtn.BorderRadius = 5;
            this.chatBtn.BorderSize = 0;
            this.chatBtn.Enabled = false;
            this.chatBtn.FlatAppearance.BorderSize = 0;
            this.chatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatBtn.ForeColor = System.Drawing.Color.White;
            this.chatBtn.Location = new System.Drawing.Point(70, 21);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(316, 32);
            this.chatBtn.TabIndex = 5;
            this.chatBtn.TextColor = System.Drawing.Color.White;
            this.chatBtn.UseVisualStyleBackColor = false;
            // 
            // Rchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.chatBtn);
            this.Name = "Rchat";
            this.Size = new System.Drawing.Size(396, 59);
            this.Load += new System.EventHandler(this.Rchat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label chatLabel;
        private Label nameLabel;
        private Label dateLabel;
        private RoundButton chatBtn;
    }
}
