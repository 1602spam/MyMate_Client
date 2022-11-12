using ClientToServer;
using Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientModules.Classes;
using ClientModules.Models;

namespace ClientModules.Controllers
{
    public static class LogInController
    {
        public static void SendLogInRequestAndWait(MdlLogIn u)
        {
            Console.WriteLine("로그인 정보 송신...");
            LoginProtocol.LOGIN l = new(u.ID, u.PW);
            Server.Instance.Send(Generater.Generate(l)); //보내고 0.1초 대기 후 리턴
            Task.Delay(100).Wait();
        }
    }
}
