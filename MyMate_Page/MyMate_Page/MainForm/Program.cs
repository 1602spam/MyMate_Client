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

            // Ŭ���̾�Ʈ ��� ����
            SvcDistributor d = SvcDistributor.Instance;

            d.PutUser(new MdlUser(1, "id", "���̸�������1��", "���̸�������1��", "asdfd", "asd", "asd"));
            d.PutUser(new MdlUser(3, "id", "���̸�������3��", "���̸�������3��", "asdfd", "asd", "asd"));
            d.PutUser(new MdlUser(4, "id", "���̸�������4��", "���̸�������4��", "asdfd", "asd", "asd"));
            d.PutUser(new MdlUser(5, "id", "���̸�������5��", "���̸�������5��", "asdfd", "asd", "asd"));

            d.PutFriend(new MdlFriend(3, "3��", false, false));
            d.PutFriend(new MdlFriend(4, "4��", false, false));
            d.PutFriend(new MdlFriend(5, "5��", false, false));

            MdlMyself.Instance.SetProperty(2, "uniqueid", "���³�����", "���³�����", "asdfd", "asd", "asd", DateTime.Now);
            Application.Run(new MainPage());
        }
    }
}