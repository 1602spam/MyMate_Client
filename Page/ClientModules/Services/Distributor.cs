using Microsoft.Azure.Amqp;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Services
{
    public static class Keys
    {
        public const int IDisplayUserInfo = 1;
    }

    public sealed class Distributor
    {
        public ConcurrentQueue<KeyValuePair<int, object>> recieveQueue = new();
        public Queue<object> qDisplayUserInfo = new();

        static private Distributor ?instance;
        static public Distributor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Distributor();
                }
                return instance;
            }
        }

        public static void runDistributor()
        {
            while (true)
            {
                if (Distributor.Instance.recieveQueue.IsEmpty == false)
                {
                    KeyValuePair<int, object> temp;
                    Distributor.Instance.recieveQueue.TryDequeue(out temp);
                    switch (temp.Key)
                    {
                        case Keys.IDisplayUserInfo:
                            {
                                Distributor.Instance.qDisplayUserInfo.Enqueue(temp.Value);
                                Console.WriteLine("value is displayuserinfo");
                            }
                            break;
                        default:
                            Console.WriteLine("알 수 없는 key");
                            break;
                    }
                }
            }
        }
    }
}
