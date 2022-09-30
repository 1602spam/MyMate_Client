using ClientModules.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page.Models
{
    public class MdlSignInUserInfo
    {
        public string ID { get; set; }
        public string PW { get; set; }

        public MdlSignInUserInfo()
        {
            this.ID = "";
            this.PW = "";
        }

        public MdlSignInUserInfo(string ID, string PW)
        {
            this.ID = ID;
            this.PW = PW;
        }

        public bool sendSignInRequest()
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
            if (Equals(this.ID, "admin") && Equals(this.PW, "1234"))
            {
                ExampleReceive.receiveObject();
                Console.WriteLine("로그인 성공");
                return true;
            }
            else
            {
                Console.WriteLine("로그인 실패");
                return false;
            }
        }
    }
}