using ClientToServer;
using Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientModules.Classes;

namespace ClientModules.Controllers
{
    public class SignInController
    {
        public static MdlLogIn enterSignInInfo(ref MdlLogIn u)
        {
            Console.WriteLine("ID를 입력하세요.");
            string ?ID = Console.ReadLine();
            Console.WriteLine("PW를 입력하세요.");
            string ?PW = Console.ReadLine();

            return new MdlLogIn(ID, PW);
        }

        public static void sendSignInRequest(MdlLogIn u)
        {
            //리퀘스트 송신
            Console.WriteLine("로그인 정보 송신...");
            LoginProtocol.Login l = new(u.ID, u.PW);
            Server.Instance.Send(Generater.Generate(l));
        }
    }
}
