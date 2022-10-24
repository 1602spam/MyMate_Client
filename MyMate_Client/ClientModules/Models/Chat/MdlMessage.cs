using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Chat
{
    public class MdlMessage
    {
        public int? Code { get; set; }
        public int? ServerCode { get; set; }
        public int? ChatroomCode { get; set; }
        public int? SenderCode { get; set; }
        public string? Message { get; set; }
        public string? Date { get; set; }
        //일정 공유 기능, 파일 전송의 경우 이 클래스를 상속해 만들도록 함
    }
}
