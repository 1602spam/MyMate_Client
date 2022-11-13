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
	public partial class ScheduleBar : UserControl
	{
		public int state;
		public int X
		{
			get { return this.Location.X; }
			set
			{
				this.Location = new Point(value, Y) ;
			}

		}
		public int Y
		{
			get{return this.Location.Y;}
			set
			{
				this.Location = new Point(X, value);
			}
		}
		public string Title
		{
			set{this.lblSchedule.Text = value;}
		}
		public bool TextVisible
		{
			set{this.lblSchedule.Visible = value;}
		}
		public ScheduleBar()
		{
			InitializeComponent();
		}
		private void ScheduleBar_Load(object sender, EventArgs e)
		{
			this.lblSchedule.Text = "";
			this.Visible = true;
			this.Size = new Size(CalendarSetting.scheduleWidth, CalendarSetting.scheduleHeight);
			//this.state = ScheduleState.BodyOnly;
			this.state = ScheduleState.Body;
			SetLocation(X, Y);
		}
		public void SetColor(Color color)
		{
			this.BackColor = color;
		}

		public void SetState(int state)
		{
			this.state = state;
			SetLocation(this.X, this.Y);
		}

		public void SetLblSize()
		{
			switch (state)
			{
				case ScheduleState.BodyOnly:
					lblSchedule.Size = new Size(
							CalendarSetting.scheduleWidth - 2 * CalendarSetting.scheduleWidhtGap,
							CalendarSetting.scheduleHeight);
					break;
				case ScheduleState.Body:
					lblSchedule.Size = new Size(
							CalendarSetting.scheduleWidth, 
							CalendarSetting.scheduleHeight);
					break;
				case ScheduleState.Head:
				case ScheduleState.Tail:
					lblSchedule.Size = new Size(
							CalendarSetting.scheduleWidth - CalendarSetting.scheduleWidhtGap,
							CalendarSetting.scheduleHeight);
					break;
				default:
					break;
			}
		}
		public void SetLocation(int x, int y)
		{
			X = x;
			Y = y;

			switch(state)
			{
				case ScheduleState.Body:
				case ScheduleState.Tail:
					lblSchedule.Location = new Point(0, 0);
					break;
				case ScheduleState.BodyOnly:
				case ScheduleState.Head:
					//lblSchedule.Location = new Point(CalendarSetting.scheduleWidhtGap, 0);
					lblSchedule.Location = new Point(10, 0);
					break;
				default:
					break;
			}

			SetLblSize();
		}

		
	}
}
