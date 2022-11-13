using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
	public partial class CalenderDay : UserControl
	{
		public Dictionary<int, ScheduleBar> scheduleBars;
		int depth;
		int Depth
		{
			get { return depth; }
			set { this.CheckDapth(value);}
		}
		public int X
		{
			get{return this.Location.X;}
			set{this.Location = new Point(value, Y);}

		}
		public int Y
		{
			get{return this.Location.Y;}
			set{this.Location = new Point(X, value);}
		}
		public string Title
		{
			set{this.lblDay.Text = value;}
		}

		public CalenderDay()
		{
			InitializeComponent();
			this.scheduleBars = new();
		}
		private void CalenderDay_Load(object sender, EventArgs e)
		{
			this.Size = new Size(CalendarSetting.DayMinWidth, CalendarSetting.DayMinHeight);
			this.depth = 0;
		}

		public void Clear()
		{
			this.scheduleBars.Clear();
			// 사이즈 최소로 지정
			this.Size = new Size(CalendarSetting.DayMinWidth, CalendarSetting.DayMinHeight);
			this.depth = 0;
		}

		public void CheckDapth(int n = 0)
		{

			int mostHeight = 0;
			if (this.scheduleBars.Count > 1)
				mostHeight = this.scheduleBars.Aggregate((x, y) => x.Key > y.Key ? x : y).Key;
			// 더 큰 것 저장
			mostHeight = mostHeight > n ? mostHeight : n;
			depth = mostHeight > depth ? mostHeight : depth;
			ReSize();
		}

		public void ReSize()
		{
			if( 2 >= depth )
			{
				this.Size = new Size(CalendarSetting.DayMinWidth, CalendarSetting.DayMinHeight);
			}

			int y = CalendarSetting.DayTitleHeight + CalendarSetting.scheduleHeightGap;

			this.Height = y + ((depth + 1) * CalendarSetting.scheduleItemHeight);
			this.panel.Dock = DockStyle.Fill;
			Replace();
		}
		public void Replace()
		{
			int y = CalendarSetting.DayTitleHeight + CalendarSetting.scheduleHeightGap;
			if (scheduleBars.Count <= 0)
				return;
			foreach (var item in scheduleBars)
			{
				item.Value.Y = y + item.Key * CalendarSetting.scheduleItemHeight;
			}
		}
		public void Add(int dapth, ScheduleBar SB)
		{
			SB.Visible = true;
			this.panel.Controls.Add(SB);
			this.scheduleBars.Add(dapth, SB);
			CheckDapth();
		}
		public void RemoveComponet(int n)
		{
			this.scheduleBars.Remove(n);
			CheckDapth();
		}

		public int MaxIndex()
		{
			return this.scheduleBars.Aggregate((x, y) => x.Key > y.Key ? x : y).Key;
		}

		// 해당 높이에 값이 있는지 확인
		public bool Check(int n)
		{
			return this.scheduleBars.ContainsKey(n);
		}

		private void lblDay_Click(object sender, EventArgs e)
		{

		}

	}
}
