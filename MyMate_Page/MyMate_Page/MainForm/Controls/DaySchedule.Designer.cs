namespace MainForm.Controls
{
    partial class DaySchedule
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
            this.Etxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STxt = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Etxt
            // 
            this.Etxt.AutoSize = true;
            this.Etxt.Location = new System.Drawing.Point(91, 116);
            this.Etxt.Name = "Etxt";
            this.Etxt.Size = new System.Drawing.Size(55, 15);
            this.Etxt.TabIndex = 11;
            this.Etxt.Text = "종료날짜";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "~";
            // 
            // STxt
            // 
            this.STxt.AutoSize = true;
            this.STxt.Location = new System.Drawing.Point(9, 116);
            this.STxt.Name = "STxt";
            this.STxt.Size = new System.Drawing.Size(55, 15);
            this.STxt.TabIndex = 9;
            this.STxt.Text = "시작날짜";
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Location = new System.Drawing.Point(9, 78);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(31, 15);
            this.titleTxt.TabIndex = 8;
            this.titleTxt.Text = "제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "진행중";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "누구누구의 스케줄";
            // 
            // DaySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Etxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.STxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DaySchedule";
            this.Size = new System.Drawing.Size(180, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Etxt;
        private Label label5;
        private Label STxt;
        private Label titleTxt;
        private Label label2;
        private Label label1;
    }
}
