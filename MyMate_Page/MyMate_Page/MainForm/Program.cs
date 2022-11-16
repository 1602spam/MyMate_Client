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

            // Ŭ���̾�Ʈ ��� ����
            SvcDistributor d = SvcDistributor.Instance;

            d.PutUser(new MdlUser(1, "id", "Mymate", "Mymate", "abc@def.com", "010-1234-5678", "�ȳ��ϼ���."));
            d.PutUser(new MdlUser(3, "id", "User3", "����3��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(4, "id", "User4", "����4��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(5, "id", "User5", "����5��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(6, "id", "User6", "����6��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(7, "id", "User7", "����7��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(8, "id", "User8", "����8��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));

            d.PutFriend(new MdlFriend(3, "ģ�� 3", false, false));
            d.PutFriend(new MdlFriend(4, "ģ�� 4", false, false));
            d.PutFriend(new MdlFriend(5, "ģ�� 5", false, false));
            d.PutFriend(new MdlFriend(6, "ģ�� 6", false, false));
            d.PutFriend(new MdlFriend(7, "ģ�� 7", false, false));
            d.PutFriend(new MdlFriend(8, "ģ�� 8", false, false));

            MdlServer server = new(1, false, "Test Server", MdlMyself.Instance.Code);
            SvcDistributor.Instance.PutServer(server);
            MdlMyself.Instance.SetProperty(2, "uniqueid", "���� �̸�", "���� �̸�", "poro912@naver.com", "010-1111-2222", "�ݰ����ϴ�.", DateTime.Now);
            //SvcDistributor.Instance.PutServer(new(3, false, "asd", MdlMyself.Instance.Code));
            Application.Run(new MainPage());
        }
    }
}