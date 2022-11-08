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
            // �� ���� ����
            MdlMyself.Instance.SetProperty(1, "�̸�", "��", "�̸���", "����", "�ڱ�Ұ�");

            SvcDistributor.Instance.PutUser(new MdlUser(2, "���̸�������1���̿���", "���̸�������1���̿���", "asdfd", "asd", "asd"));
            Application.Run(new MainPage());
        }
    }
}