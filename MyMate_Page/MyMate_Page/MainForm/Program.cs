using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Services;

namespace MainForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // 클라이언트 모듈 시작
            SvcDistributor d = SvcDistributor.Instance;

            d.PutUser(new MdlUser(1, "id", "Mymate", "Mymate", "abc@def.com", "010-1234-5678", "안녕하세요."));
            d.PutUser(new MdlUser(3, "id", "내이름은유저3번", "내이름은유저3번", "abc@def.com", "010-2345-6789", "자기소개"));
            d.PutUser(new MdlUser(4, "id", "내이름은유저4번", "내이름은유저4번", "abc@def.com", "010-2345-6789", "자기소개"));
            d.PutUser(new MdlUser(5, "id", "내이름은유저5번", "내이름은유저5번", "abc@def.com", "010-2345-6789", "자기소개"));

            d.PutFriend(new MdlFriend(3, "친구 3", false, false));
            d.PutFriend(new MdlFriend(4, "친구 4", false, false));
            d.PutFriend(new MdlFriend(5, "친구 5", false, false));

            MdlServer server = new(1, false, "Test Server", MdlMyself.Instance.Code);
            SvcDistributor.Instance.PutServer(server);
            MdlMyself.Instance.SetProperty(2, "uniqueid", "나의 이름", "나의 이름", "poro912@naver.com", "010-1111-2222", "반갑습니다.", DateTime.Now);
            //SvcDistributor.Instance.PutServer(new(3, false, "asd", MdlMyself.Instance.Code));
            Application.Run(new MainPage());
        }
    }
}