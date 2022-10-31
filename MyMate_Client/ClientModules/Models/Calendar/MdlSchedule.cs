using ClientModules.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Calendar
{
    public class MdlSchedule
    {
        //캘린더 코드
        public int Code { get; set; }
        //캘린더가 속한 서버 코드
        public int ServerCode { get; set; }
        //캘린더를 생성한 유저의 코드
        public int OwnerCode { get; set; }
        //캘린더 제목
        public string Title { get; set; }
        //캘린더를 공유받은 사람 ??????? 이미 받았는데 공유받은 사람이 뭐가 중요한지 모르겠지만 쓸 데 있을 수도 있어서 일단 넣어 두기
        public ScheduleItemContainer Items { get; set; }
    }
}
