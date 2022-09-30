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
        public string ?ID { get; set; }
        public string ?PW { get; set; }

        public bool FlagSignOn { get; set; }

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

        public void enterSignInInfo()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("ID 입력...");
            this.ID = Console.ReadLine();
            Console.WriteLine("PW 입력...");
            this.PW = Console.ReadLine();
            Console.WriteLine("------------------------");
        }

        public void logoutCheck()
        {
            while (true)
            {
                Console.WriteLine("로그아웃하시려면 '나가' 라고 입력...");
                if (Console.ReadLine() == "나가")
                {
                    Console.WriteLine("로그아웃되었습니다.");
                    SvcDistributor.Instance.clearAllCollection();
                    break;
                }
            }
        }

        public void sendSignInRequest()
        {
            //리퀘스트 송신
            Console.WriteLine("로그인 정보 송신...");
            Console.WriteLine("서버가 DB 데이터 대조 중...");
            Console.WriteLine("DB: ID는 admin, PW는 1234, 대조 후 맞으면 1, 아니면 0 반환");
        }

        public void recvSignInResponse()
        {
            // 서버로부터 받은 value(object)를 null check 해서 로그인 성공 여부를 표시!
            if (Equals(this.ID, "admin") && Equals(this.PW, "1234"))
                notifySignInSucceed();
            else
                notifySignInFailed();
        }

        private void notifySignInSucceed()
        {
            SvcExampleReceive.receiveObject();
            Console.WriteLine("로그인 성공");
            FlagSignOn = true;
        }

        private void notifySignInFailed()
        {
            Console.WriteLine("로그인 실패");
            FlagSignOn = false;
        }
    }
}