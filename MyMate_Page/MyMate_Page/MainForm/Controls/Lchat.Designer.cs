namespace MainForm.Controls
{
    partial class Lchat
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
            this.chatBtn = new MainForm.Controls.RoundButton();
            this.roundButton2 = new MainForm.Controls.RoundButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.chatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chatBtn
            // 
            this.chatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.chatBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.chatBtn.BorderColor = System.Drawing.Color.Red;
            this.chatBtn.BorderRadius = 5;
            this.chatBtn.BorderSize = 0;
            this.chatBtn.Enabled = false;
            this.chatBtn.FlatAppearance.BorderSize = 0;
            this.chatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatBtn.ForeColor = System.Drawing.Color.White;
            this.chatBtn.Location = new System.Drawing.Point(48, 21);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(316, 34);
            this.chatBtn.TabIndex = 0;
            this.chatBtn.TextColor = System.Drawing.Color.White;
            this.chatBtn.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(138)))), ((int)(((byte)(247)))));
            this.roundButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(138)))), ((int)(((byte)(247)))));
            this.roundButton2.BorderColor = System.Drawing.Color.Red;
            this.roundButton2.BorderRadius = 18;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(8, 7);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(36, 36);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(56, 5);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "2022.11.01";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(307, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Goguma";
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.chatLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatLabel.Location = new System.Drawing.Point(56, 30);
            this.chatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.chatLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(200, 15);
            this.chatLabel.TabIndex = 4;
            this.chatLabel.Text = "label1";
            // 
            // Lchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.chatBtn);
            this.Name = "Lchat";
            this.Size = new System.Drawing.Size(373, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton chatBtn;
        private RoundButton roundButton2;
        private Label dateLabel;
        private Label nameLabel;
        private Label chatLabel;
    }
}
