using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
	public class Schedule
	{
		public int depth;
		public int length;
		public TimeSpan day;
		public int center;
		public List<ScheduleBar> bars;

		private string title;
		public string Title
		{
			get{return title;}
			set
			{
				title = value;
			}
		}
		public DateTime start;
		public DateTime Start
		{
			get{return start;}
			set
			{
				start = value;
				Refresh();
			}
		}
		public DateTime end;
		public DateTime End
		{
			get{return end;}
			set
			{
				end = value;
				Refresh();
			}
		}
		
		public Schedule(string title, DateTime? start = null, DateTime? end = null)
		{
			this.title = title;

			// null값이라면 현재날짜 - 1 
			if (null == start)
				this.start = DateTime.Now.AddDays(-1);
			else
				this.start = (DateTime)start;

			// null 이라면 현재날짜 + 1
			if (null == end)
				this.start = DateTime.Now.AddDays(+1);
			else
				this.end = (DateTime)end;

			// schduleBar 객체를 담을 List 생성
			bars = new();

			// 총 일수
			this.day = this.end - this.start;

			// 총 길이
			this.length = day.Days + 1;
			center = length / 2;
			


			Refresh();
		}

		public void SetColor(Color color)
		{
			foreach (ScheduleBar bar in bars)
				bar.SetColor(color);
		}

		public void SetCenter(int startIdx, int endIdx)
		{
			int tempIdx = endIdx - startIdx;
			// 기존의 Body의 Text를 없앰
			//bars[center].Visible = false;
			bars[center].Title = "";

			center = startIdx +  tempIdx / 2;
			bars[center].Title = this.title;
			//bars[center].Visible = true;
		}
		public void Refresh()
		{
			this.day = this.end - this.start;
			this.length = day.Days + 1;

			center = length / 2;

			bars.Clear();

			// 생성하며 Body로 만들어짐
			for (int i = 0; i < this.length; ++i)
			{
				ScheduleBar bar = new();
				bar.AutoSize = false;
				bars.Add(bar);
			}

			SetCenter(0, this.length - 1);

			// 한칸인경우
			if (1 == length)
			{
				bars[0].SetState(ScheduleState.BodyOnly);
				bars[0].Title = title;
				bars[0].Visible = true;
				return;
			}
			// 두칸인 경우
			else if (2 == length)
			{
				bars[0].SetState(ScheduleState.Head);
				bars[0].Title = title;
				bars[0].Visible = true;
				bars[1].SetState(ScheduleState.Tail);
				return;
			}
			// 두칸 이상인 경우
			else if (2 <= length)
			{
				// 각 바의 상태를 변환한다.
				bars[0].SetState(ScheduleState.Head);
				bars[length - 1].SetState(ScheduleState.Tail);
				//bars[center].SetCenter();
				SetCenter(0, this.length - 1);
				return;
			}
		}
	}
}
