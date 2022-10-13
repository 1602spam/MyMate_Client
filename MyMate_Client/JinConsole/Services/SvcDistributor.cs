using ClientNetwork;
using Page.Models;
using Protocol;
using Protocol.Protocols;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcdResult = System.Collections.Generic.KeyValuePair<byte, object?>;

namespace JinConsole.Unused
{
	public static class Keys
	{
		public const int KeyDisplayUserInfo = 1;
	}

	public sealed class SvcDistributor
	{
        private List<byte>? bytes;
        private RcdResult result;

        private ConcurrentBag<MdlDisplayUserInfo> ColDisplayUserInfo = new();
        // 싱글턴 구현
        // Distributor.Instance.~~~로 접근
        static private SvcDistributor? instance;
		static public SvcDistributor Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SvcDistributor();
					Console.WriteLine("distributor 실행됨");
				}
				return instance;
			}
		}

		private SvcDistributor() {
			Server.Instance.receive.ReceiveEvent += taskDistributor;
		}

		// 수신 큐에 KeyValuePair가 들어오면 읽어서 해당 오브젝트 큐로 전송
		public static void taskDistributor()
		{
			if (!Server.Instance.receive.isEmpty())
            {
                // 데이터를 읽어옴
                Server.Instance.receive.Pop(out Instance.bytes);
                Instance.result = Converter.Convert(Instance.bytes);

                // 읽어온 데이터가 없다면 Continue
                if (null != Instance.result.Value)
					estimateObject(Instance.result);
            }
        }

		public static void estimateObject(KeyValuePair<byte, object> temp)
		{
			switch (temp.Key)
			{
				case Protocol.DataType.USER_INFO:
					{
						UserInfoProtocol.User? userinfo;
						userinfo = temp.Value as UserInfoProtocol.User;
						MdlDisplayUserInfo d = new(userinfo);

                        if (d.nullCheck())
                            return;

                        Instance.ColDisplayUserInfo.Add(d);
                        Console.WriteLine("---------");
                        Console.WriteLine(d.UserCode);
						Console.WriteLine(d.ID);
                        Console.WriteLine(d.Name);
                        Console.WriteLine(d.Nick);
                        Console.WriteLine(d.PhoneNumber);
                        Console.WriteLine("---------");
                    }
					break;

				default:
					Console.WriteLine("failed to enqueue the value: undefined");
					break;
			}
		}
	}
}
