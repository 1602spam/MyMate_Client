using ClientModules.Models;
using ClientModules.Services;
using System.Security.Cryptography;

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

            SvcDistributor d = SvcDistributor.Instance;
            MdlMyself.Instance.SetProperty(1, "이름", "닉", "이메일", "폰번", "자기소개");
            Application.Run(new LoginForm());
        }
    }
}