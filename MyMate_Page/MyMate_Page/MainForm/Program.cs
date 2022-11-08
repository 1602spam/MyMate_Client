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
            // 내 정보 설정
            MdlMyself.Instance.SetProperty(1, "이름", "닉", "이메일", "폰번", "자기소개");

            SvcDistributor.Instance.PutUser(new MdlUser(2, "내이름은유저1번이예요", "내이름은유저1번이예요", "asdfd", "asd", "asd"));
            Application.Run(new MainPage());
        }
    }
}