using Protocol;
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
        public int Creator { get; set; }
        //메시지 내용
        public string Context { get; set; }
        //메시지 보낸 시간
        public DateTime Time { get; set; }
        public bool IsDeleted { get; set; }
        public MdlMessage() { }
        public MdlMessage(int code, int serverCode, int chatroomCode, int senderCode, string context, DateTime time)
        {
            Code = code;
            ServerCode = serverCode;
            ChatroomCode = chatroomCode;
            Creator = senderCode;
            Context = context;
            Time = time;
        }
        public MdlMessage(MessageProtocol.MESSAGE message)
        {
            this.Code = message.messageCode;
            this.ServerCode = message.serverCode;
            this.ChatroomCode = message.channelCode;
            this.Creator = message.creater;
            this.Context = message.content;
            this.Time = message.startTime;
            //this.IsDeleted = message.isDeleted;
        }

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
                if (Creator != 0)
                    break;
                if (Context != "")
                    break;
                return true;
            } while (false);

            return false;
        }
    }
}
