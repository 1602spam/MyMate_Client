namespace Calender
{
	partial class CalenderDay
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
			this.lblDay = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDay
			// 
			this.lblDay.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblDay.Location = new System.Drawing.Point(0, 0);
			this.lblDay.Name = "lblDay";
			this.lblDay.Size = new System.Drawing.Size(100, 30);
			this.lblDay.TabIndex = 0;
			this.lblDay.Text = "label1";
			this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDay.Click += new System.EventHandler(this.lblDay_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.lblDay);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(100, 76);
			this.panel.TabIndex = 1;
			// 
			// CalenderDay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel);
			this.Name = "CalenderDay";
			this.Size = new System.Drawing.Size(100, 76);
			this.Load += new System.EventHandler(this.CalenderDay_Load);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Label lblDay;
		private Panel panel;
	}
}
