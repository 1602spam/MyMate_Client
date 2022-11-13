namespace Calender
{
	partial class Calender
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
			this.Panel = new System.Windows.Forms.TableLayoutPanel();
			this.lblMonth = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Panel
			// 
			this.Panel.AutoScroll = true;
			this.Panel.AutoSize = true;
			this.Panel.BackColor = System.Drawing.Color.White;
			this.Panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.Panel.ColumnCount = 7;
			this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel.Location = new System.Drawing.Point(0, 0);
			this.Panel.Name = "Panel";
			this.Panel.RowCount = 2;
			this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.Panel.Size = new System.Drawing.Size(712, 129);
			this.Panel.TabIndex = 0;
			// 
			// lblMonth
			// 
			this.lblMonth.BackColor = System.Drawing.Color.White;
			this.lblMonth.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblMonth.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMonth.Location = new System.Drawing.Point(0, 0);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(712, 50);
			this.lblMonth.TabIndex = 1;
			this.lblMonth.Text = "xxxx년 xx월";
			this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Calender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.lblMonth);
			this.Controls.Add(this.Panel);
			this.Name = "Calender";
			this.Size = new System.Drawing.Size(712, 129);
			this.Load += new System.EventHandler(this.Calender_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TableLayoutPanel Panel;
		private Label lblMonth;
	}
}
