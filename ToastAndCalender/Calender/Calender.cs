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
	public partial class Calender : UserControl
	{
		public int year;
		public int month;
		public int lastDay;
		public int dayWidth;
		public int dayHeight;
		public DateTime monthStartDay;
		public DateTime monthEndDay;

		public DayOfWeek week;

		public List<Schedule> schedules;
		public CalenderDay[] days;

		public int[,] startEndIndex = new int[6, 2];

		public Calender()
		{
			InitializeComponent();
		}

		private void Calender_Load(object sender, EventArgs e)
		{
			
		}

		public void Set(int year, int month)
		{
			this.year = year;
			this.month = month;
			this.lblMonth.Text = this.year + " 년 " + this.month + " 월";

			// 마지막날짜 저장
			this.lastDay = DateTime.DaysInMonth(year, month);

			// 처음과 마지막날을 DateTime으로 저장
			this.monthStartDay = new DateTime(year, month, 1);
			this.monthEndDay = new DateTime(year, month, lastDay);

			// 첫날의 주차를 저장
			this.week = this.monthStartDay.DayOfWeek;

			// 첫주의 시작과 끝
			startEndIndex[0, 0] = 1;
			startEndIndex[0, 1] = 1 + (6 - (int)this.week);

			for (int i = 1; i < 5; ++i)
			{
				// 시작날짜는 전주의 마지막 날짜 + 1
				startEndIndex[i, 0] = startEndIndex[i - 1, 1] + 1;
				// 마지막날짜는 시작날짜의 + 6
				startEndIndex[i, 1] = startEndIndex[i, 0] + 6;
			}

			for(int i = 0; i < ((int)week+7); ++i)
			{
				this.Panel.Controls.Add(new Label());
			}
			// 0일은 없으므로 사용하지 않는다.
			// 각 날짜에 객체 생성
			days = new CalenderDay[lastDay + 1];
			days[0] = new();
			for (int i = 1; i < lastDay + 1; ++i)
			{
				days[i] = new();
				days[i].Title = i.ToString();
				this.Panel.Controls.Add(days[i]);
			}

			schedules = new();
		}

		public void Clear()
		{
			this.schedules.Clear();
			// 모든 리스트 초기화
			foreach(CalenderDay d in days)
				d.Clear();
		}
		public void Add(string title, DateTime? start = null, DateTime? end = null)
		{
			Schedule schedule = new(title, start, end);
			this.schedules.Add(schedule);
			SchduleReplace();
			schedule.SetCenter(0, 0);
		}

		public void Add(Schedule schedule)
		{
			this.schedules.Add(schedule);
			schedule.SetCenter(0, schedule.length - 1);
			SchduleReplace();
		}
		public void Add(List<Schedule> schedule)
		{
			foreach (Schedule s in schedules)
			{
				this.schedules.Add(s);
				s.SetCenter(0, s.length - 1);
			}
				
			SchduleReplace();
		}

		// 길이 기준 정렬
		public void Sort()
		{
			// 그리기를 하기 전 호출
			// 스케줄을 길이 기준으로 역순 정렬
			// 내림차순
			this.schedules.Sort((scheduleA, scheduleB)
				=> scheduleB.length.CompareTo(scheduleA.length));
			// 오름차순
			//this.schedules.Sort((scheduleA, scheduleB)
			//	=> scheduleA.length.CompareTo(scheduleB.length));
		}

		public void SchduleReplace()
		{
			// 삽입이 가능한 시작, 끝 날짜
			int start;
			int end;

			// 삽입이 가능한 깊이
			int dep = 0;

			int scheduleIndex = 0;

			// 모든 스케줄 바를 지운다.
			foreach (var d in days)
				d.Clear();

			Sort();

			// 가장 긴 스케줄부터 삽입에 들어감
			foreach (Schedule s in schedules)
			{
				// 유효한 일정인지 확인
				// 두 날짜 모두 시작날짜보다 작다면
				if (s.start < this.monthStartDay && s.end < this.monthStartDay)
					continue;
				// 두 날짜 모두 끝 날짜보다 크다면
				if (this.monthEndDay < s.start && this.monthEndDay < s.end)
					continue;

				// 범위를 초과하면 현재에서 가능한날로 변환
				if (s.start < this.monthStartDay)
					start = this.monthStartDay.Day;
				else
					start = s.start.Day;

				if (this.monthEndDay < s.end)
					end = this.monthEndDay.Day;
				else
					end = s.end.Day;

				// 넣을 수 있는 깊이 측정
				dep = CheckAbleInsert(start, end);

				// 버그 가능성 높음
				// 스케줄의 시작날짜가 캘린더의 1일보다 먼저라면
				if (s.start < this.monthStartDay)
					scheduleIndex = (this.monthStartDay - s.start).Days;
				else
					scheduleIndex = 0;

				s.SetCenter(scheduleIndex, scheduleIndex + (end - start));

				for (int i = start; i <= end; ++i, ++scheduleIndex)
				{
					days[i].Add(dep, s.bars[scheduleIndex]);
				}
			}
		}

		// 시작날짜부터 끝 날짜까지 삽입 가능한 depth를 구함
		public int CheckAbleInsert(int s, int e)
		{
			int n = 0;
			int i = 0;
			while (true)
			{
				for(i = s; i <= e; ++i)
				{
					// 해당 날짜에 넣는게 불가능하다면
					// true 삽입 불가능
					if(days[i].Check(n))
					{
						++n;
						break;
					}
				}
				// i가 e보다 크다면 전부 확인한 것이므로 탈출
				if (i > e)
					break;
			}
			return n;
		}
	}
}
