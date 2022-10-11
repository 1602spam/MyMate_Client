using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Page.Models;

namespace ClientModules.Services
{
    public static class SvcExampleReceive
    {
        public static void receiveObject()
        {
            // 오브젝트 수신, 이 때 key값은 1, value는 MdlDisplayUserInfo를 object로 받는다고 가정함
            KeyValuePair<int, object> kvp = new KeyValuePair<int, object>(1, new MdlDisplayUserInfo(20, "장진", 1, "1602spam@naver.com", "010-3758-6015"));
            SvcDistributor.Instance.recieveQueue.Enqueue(kvp);
            Console.WriteLine("successfully enqueued the received object in the distributor queue.");
        }
    }
}
