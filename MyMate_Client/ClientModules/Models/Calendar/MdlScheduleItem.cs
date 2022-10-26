using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Calendar
{
    public class MdlScheduleItem
    {
        //스케줄 일정 항목 코드
        public int Code { get; set; }
        //스케줄 코드
        //스케줄 객체를 불러올 때 해당 스케줄 코드를 가진 스케줄 아이템을 함께 불러옴
        public int ScheduleCode { get; set; }
        //스케줄 항목 제목
        public string Title { get; set; }
        //스케줄 시작 날짜
        public string StartDate { get; set; }
        //스케줄 종료 날짜
        public string EndDate { get; set; }
        //내용(내지 메모)
        public string Content { get; set; }
        //항목 공개 여부
        public bool IsPrivate { get; set; }
        //완료 여부
        public bool IsDone { get; set; }
    }
}
