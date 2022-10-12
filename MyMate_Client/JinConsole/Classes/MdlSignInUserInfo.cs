using JinConsole.Unused;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page.Models
{
    //

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

        public void enterSignInInfo()
        {
            Console.WriteLine("ID를 입력하세요.");
            this.ID = Console.ReadLine();
            Console.WriteLine("PW를 입력하세요.");
            this.PW = Console.ReadLine();
        }

        public void logoutCheck()
        {
            while (FlagSignOn)
            {
                Console.WriteLine("로그아웃되었습니다.");
                FlagSignOn = false;
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
            // 서버로부터 받은 value(object)를 null check 해서 로그인 성공 여부를 표시
            if (Equals(this.ID, "admin") && Equals(this.PW, "1234"))
                onSignInSucceed();
            else
                onSignInFailed();
        }

        private void onSignInSucceed()
        {
            Console.WriteLine("로그인 성공");
            FlagSignOn = true;
        }

        private void onSignInFailed()
        {
            Console.WriteLine("로그인 실패");
            FlagSignOn = false;
        }
    }
}