using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Services;
using ClientNetwork;

namespace WinformTest
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

            //Server server = Server.Instance;
            //SvcDistributor d = SvcDistributor.Instance;

            MdlUser user = new(1, "asdf", "asdf", 1, "asdf", "01011010101", "하이");
            UserContainer.AddOrUpdate(user.Code, user);
            user = new(1, "asdf", "asdf", 1, "asdf", "01011010101", "난 변경되었습니다~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            UserContainer.AddOrUpdate(user.Code, user);
            user = new(2, "asdf", "asdf", 1, "asdf", "01011010101", "하이");
            UserContainer.AddOrUpdate(user.Code, user);
            user = new(3, "asdf", "asdf", 1, "asdf", "01011010101", "하이");
            UserContainer.AddOrUpdate(user.Code, user);

            for (int i = 4; i <= 10; i++)
            {
                user = new(i, "asdf", "asdf", 1, "asdf", "01011010101", $"나는 {i}번");
                UserContainer.AddOrUpdate(user.Code, user);
            }

            Application.Run(new Form1());
        }
    }
}