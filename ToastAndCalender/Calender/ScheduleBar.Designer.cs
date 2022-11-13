namespace Calender
{
	partial class ScheduleBar
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
			this.lblSchedule = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblSchedule
			// 
			this.lblSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblSchedule.Location = new System.Drawing.Point(0, 0);
			this.lblSchedule.Name = "lblSchedule";
			this.lblSchedule.Size = new System.Drawing.Size(100, 20);
			this.lblSchedule.TabIndex = 0;
			this.lblSchedule.Text = "label1";
			this.lblSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ScheduleBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lblSchedule);
			this.Name = "ScheduleBar";
			this.Size = new System.Drawing.Size(100, 20);
			this.Load += new System.EventHandler(this.ScheduleBar_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Label lblSchedule;
	}
}
