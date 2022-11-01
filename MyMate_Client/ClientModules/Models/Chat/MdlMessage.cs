using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Chat
{
    public class MdlMessage
    {
        //메시지 코드
        public int Code { get; set; }
        //서버 코드
        public int ServerCode { get; set; }
        //채팅방 코드
        public int ChatroomCode { get; set; }
        //메시지 보낸 유저 코드
        public int SenderCode { get; set; }
        //메시지 내용
        public string Message { get; set; }
        //메시지 보낸 시간
        public DateTime Time { get; set; }
        //일정 공유 기능, 파일 전송의 경우 이 클래스를 상속해 만들도록 함
        public bool nullCheck()
        {
            do
            {
                if (Code != 0)
                    break;
                if (ServerCode != 0)
                    break;
                if (ChatroomCode != 0)
                    break;
                if (SenderCode != 0)
                    break;
                if (Message != "")
                return true;
            } while (false);

            return false;
        }
    }
}
