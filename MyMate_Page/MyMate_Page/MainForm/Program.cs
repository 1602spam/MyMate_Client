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

            d.PutUser(new MdlUser(1, "id", "상대방", "상대방", "other@def.com", "010-1234-5678", "안녕하세요."));
            d.PutUser(new MdlUser(3, "id", "편성윤", "편성윤", "abc@def.com", "010-2345-6789", "안녕하세요 psy 싸이 입니다"));
            d.PutUser(new MdlUser(4, "id", "장진", "장진", "abc@def.com", "010-2345-6789", "반갑습니다."));
            d.PutUser(new MdlUser(5, "id", "이무현", "이무현", "abc@def.com", "010-2345-6789", "자기소개"));
            d.PutUser(new MdlUser(6, "id", "김호경", "김호경", "abc@def.com", "010-2345-6789", "자기소개"));
            d.PutUser(new MdlUser(7, "id", "김예지", "김예지", "abc@def.com", "010-2345-6789", "자기소개"));
            d.PutUser(new MdlUser(8, "id", "최민호", "최민호", "abc@def.com", "010-2345-6789", "자기소개"));

            d.PutFriend(new MdlFriend(3, "편성윤", false, false));
            d.PutFriend(new MdlFriend(4, "장진", false, false));
            d.PutFriend(new MdlFriend(5, "이무현", false, false));
            d.PutFriend(new MdlFriend(6, "김호경", false, false));
            d.PutFriend(new MdlFriend(7, "김예지", false, false));
            d.PutFriend(new MdlFriend(8, "최민호", false, false));

            MdlServer server = new(1, false, "Test Server", MdlMyself.Instance.Code);
            SvcDistributor.Instance.PutServer(server);
            MdlMyself.Instance.SetProperty(2, "uniqueid", "MyMate", "MyMate", "abc@naver.com", "010-1111-2222", "반갑습니다. 자기소개 란입니다.", DateTime.Now);
            //SvcDistributor.Instance.PutServer(new(3, false, "asd", MdlMyself.Instance.Code));
            Application.Run(new MainPage());
        }
    }
}