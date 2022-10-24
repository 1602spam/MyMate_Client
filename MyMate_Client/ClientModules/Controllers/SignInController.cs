using ClientNetwork;
using Protocol.Protocols;
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
        public static MdlSignInUserInfo enterSignInInfo(ref MdlSignInUserInfo u)
        {
            Console.WriteLine("ID를 입력하세요.");
            string ?ID = Console.ReadLine();
            Console.WriteLine("PW를 입력하세요.");
            string ?PW = Console.ReadLine();

            return new MdlSignInUserInfo(ID, PW);
        }

        public static void sendSignInRequest(MdlSignInUserInfo u)
        {
            //리퀘스트 송신
            Console.WriteLine("로그인 정보 송신...");
            List<byte> bytes;
            bytes = new();
            LoginProtocol.Login l = new(u.ID, u.PW);
            Generater.Generate(l, ref bytes);
            Server.Instance.send.Data(bytes);
        }
    }
}
