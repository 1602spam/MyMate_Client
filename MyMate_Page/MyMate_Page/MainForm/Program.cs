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

            d.PutUser(new MdlUser(1, "내이름은유저1번이예요", "내이름은유저1번이예요", "asdfd", "asd", "asd"));
            Application.Run(new MainPage());
        }
    }
}