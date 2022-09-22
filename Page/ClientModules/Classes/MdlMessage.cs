using ClientModules.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page.Models
{
    public class MdlMessage
    {
        public int UserCode { get; set; }
        public string UserName { get; set; }
        public int ChannelCode { get; set; }
        public string Message { get; set; }
        public int Time { get; set; }

        public MdlMessage()
        {
            this.UserCode = 0;
            this.UserName = "";
            this.ChannelCode = 0;
            this.Message = "";
            this.Time = 0;

        }

        public MdlMessage(int userCode, string userName, int channelCode, string message, int time)
        {
            this.UserCode = userCode;
            this.UserName = userName;
            this.ChannelCode = channelCode;
            this.Message = message;
            this.Time = time;
        }

        public bool sendMessageRequest()
        {
            bool b = false;
            //리퀘스트 송신
            Console.WriteLine("로그인 정보 송신...");
            Console.WriteLine("서버가 DB 데이터 대조 중...");
            Console.WriteLine("DB: ID는 admin, PW는 1234, 대조 후 맞으면 1, 아니면 0 반환");
            b = recvSignInResponse();
            return b;
        }

        public bool recvSignInResponse()
        {
        }
    }
}