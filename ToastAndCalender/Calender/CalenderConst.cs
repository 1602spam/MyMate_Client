using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
	public static class CalendarSetting
	{
		// 캘린더
		public const int TitleHeight = 30;

		public const int CalendarMinHeight = 5 * DayMinHeight;
		public const int CalendarMinWidth = 7 * scheduleWidth;

		// 날짜
		// 날짜 표시 높이
		public const int DayTitleHeight = 30;
		// 최소 길이
		public const int DayMinWidth = scheduleWidth;
		// 최소 높이
		public const int DayMinHeight = DayTitleHeight + 2 * scheduleItemHeight + scheduleHeightGap;

		// 스케줄
		// 스케줄 크기
		public const int scheduleHeight = 20;
		public const int scheduleWidth = 100;

		// 스케줄끼리의 간격
		public const int scheduleHeightGap = 2;
		public const int scheduleWidhtGap = 10;

		// 크기 + 간격
		public const int scheduleItemHeight = scheduleHeight + scheduleHeightGap;
		public const int scheduleItemWidth = scheduleWidth + scheduleWidhtGap;
	}
	public static class ScheduleState
	{
		public const int BodyOnly = 0;
		public const int Head = 1;
		public const int Body = 2;
		public const int Tail = 3;
	}
}
