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
        public List<int> Users { get; set; }
        public ScheduleItemContainer Items { get; set; }
        public MdlSchedule() {}
        public MdlSchedule(int code, int serverCode, int ownerCode, string title, ScheduleItemContainer items)
        {
            Code = code;
            ServerCode = serverCode;
            OwnerCode = ownerCode;
            Title = title;
            Items = new();
        }

        public bool nullCheck()
        {
            do
            {
                if (Code != 0)
                    break;
                if (ServerCode != 0)
                    break;
                if (OwnerCode != 0)
                    break;
                return true;
            } while (false);

            return false;
        }
    }
}
