using ClientModules.Containers;
using Protocol;
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
        public bool IsDeleted { get; set; }

        private MdlSchedule() {}
        public MdlSchedule(int code, int serverCode, int ownerCode, string title)
        {
            Code = code;
            ServerCode = serverCode;
            OwnerCode = ownerCode;
            Title = title;
            Items = new ScheduleItemContainer();
        }

        public MdlSchedule(ChannelProtocol.CHNNEL c)
        {
            Code = c.channelCode;
            ServerCode = c.serverCode;
            //OwnerCode = c.creator;
            Title = c.title;
            //Items = c.users;
            //IsDeleted = c.isDeleted;
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
