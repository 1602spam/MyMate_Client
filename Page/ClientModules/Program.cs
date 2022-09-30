// See https://aka.ms/new-console-template for more information

using ClientModules.Services;
using Page.Models;

MdlSignInUserInfo signInUserInfo;

string ID = "";
string PW = "";

Thread t = new Thread(Distributor.runDistributor);
t.IsBackground = true;
t.Start();

while (true)
{
    ID = "";
    PW = "";

#pragma warning disable CS8600
    Console.WriteLine("ID 입력...");
    ID = Console.ReadLine();
    Console.WriteLine("PW 입력...");
    PW = Console.ReadLine();
#pragma warning restore CS8600

    if (ID == null || PW == null)
        continue;

    signInUserInfo = new MdlSignInUserInfo(ID, PW);
    if (signInUserInfo.sendSignInRequest())
    {
        while (true)
        {
            Console.WriteLine("로그아웃하시려면 '꺼져' 라고 입력...");
            if (Console.ReadLine() == "꺼져")
            {
                Console.WriteLine("로그아웃되었습니다.");
                break;
            }
        }
    }
}