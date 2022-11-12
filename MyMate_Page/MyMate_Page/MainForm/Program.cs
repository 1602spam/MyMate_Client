using ClientModules.Models;
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

            d.PutUser(new MdlUser(1, "id", "내이름은유저1번", "내이름은유저1번", "asdfd", "asd", "asd"));
            d.PutUser(new MdlUser(3, "id", "내이름은유저3번", "내이름은유저3번", "asdfd", "asd", "asd"));
            d.PutUser(new MdlUser(4, "id", "내이름은유저4번", "내이름은유저4번", "asdfd", "asd", "asd"));
            d.PutUser(new MdlUser(5, "id", "내이름은유저5번", "내이름은유저5번", "asdfd", "asd", "asd"));

            d.PutFriend(new MdlFriend(3, "3번", false, false));
            d.PutFriend(new MdlFriend(4, "4번", false, false));
            d.PutFriend(new MdlFriend(5, "5번", false, false));

            MdlMyself.Instance.SetProperty(2, "uniqueid", "나는나예요", "나는나예요", "asdfd", "asd", "asd", DateTime.Now);
            Application.Run(new MainPage());
        }
    }
}