using Page.Models;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinConsole.Unused
{
    public static class Keys
    {
        public const int KeyDisplayUserInfo = 1;
    }

    public sealed class SvcDistributor
    {
        // 멀티 스레드 안전한 int, object key/value 페어를 받는 수신 큐
        public ConcurrentQueue<KeyValuePair<int, object>> recieveQueue = new();
        // key에 따라 분류된 오브젝트별 큐
        public ConcurrentBag<object> ColDisplayUserInfo = new();

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
                }
                return instance;
            }
        }

        // 스레드 동작 함수
        // 수신 큐에 KeyValuePair가 들어오면 읽어서 해당 오브젝트 큐로 전송
        public static void taskDistributor()
        {
            while (true)
            {
                if (Instance.recieveQueue.IsEmpty == false)
                {
                    KeyValuePair<int, object> temp;
                    Instance.recieveQueue.TryDequeue(out temp);
                    estimateObject(temp);
                }
            }
        }

        public static void estimateObject(KeyValuePair<int, object> temp)
        {
            switch (temp.Key)
            {
                case Protocol.DataType.USER_INFO:

                /*
                case Keys.KeyDisplayUserInfo:
                    {
                        if (((MdlDisplayUserInfo)temp.Value).nullCheck())
                            return;

                        Instance.ColDisplayUserInfo.Add(temp.Value);
                    }
                    break;
                */

                default:
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("failed to enqueue the value: undefined");
                    Console.WriteLine("-----------------------------------------------------");
                    break;
            }
        }

        public void clearAllCollection()
        {
            Instance.recieveQueue.Clear();
            Instance.ColDisplayUserInfo.Clear();
        }
    }
}
