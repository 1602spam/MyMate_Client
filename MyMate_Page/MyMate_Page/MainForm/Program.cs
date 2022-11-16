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

            d.PutUser(new MdlUser(1, "id", "����", "����", "other@def.com", "010-1234-5678", "�ȳ��ϼ���."));
            d.PutUser(new MdlUser(3, "id", "����", "����", "abc@def.com", "010-2345-6789", "�ȳ��ϼ��� psy ���� �Դϴ�"));
            d.PutUser(new MdlUser(4, "id", "����", "����", "abc@def.com", "010-2345-6789", "�ݰ����ϴ�."));
            d.PutUser(new MdlUser(5, "id", "�̹���", "�̹���", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(6, "id", "��ȣ��", "��ȣ��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(7, "id", "�迹��", "�迹��", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));
            d.PutUser(new MdlUser(8, "id", "�ֹ�ȣ", "�ֹ�ȣ", "abc@def.com", "010-2345-6789", "�ڱ�Ұ�"));

            d.PutFriend(new MdlFriend(3, "����", false, false));
            d.PutFriend(new MdlFriend(4, "����", false, false));
            d.PutFriend(new MdlFriend(5, "�̹���", false, false));
            d.PutFriend(new MdlFriend(6, "��ȣ��", false, false));
            d.PutFriend(new MdlFriend(7, "�迹��", false, false));
            d.PutFriend(new MdlFriend(8, "�ֹ�ȣ", false, false));

            MdlServer server = new(1, false, "Test Server", MdlMyself.Instance.Code);
            SvcDistributor.Instance.PutServer(server);
            MdlMyself.Instance.SetProperty(2, "uniqueid", "MyMate", "MyMate", "abc@naver.com", "010-1111-2222", "�ݰ����ϴ�. �ڱ�Ұ� ���Դϴ�.", DateTime.Now);
            //SvcDistributor.Instance.PutServer(new(3, false, "asd", MdlMyself.Instance.Code));
            Application.Run(new MainPage());
        }
    }
}