using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Page.Models;

namespace ClientModules.Services
{
    public static class ExampleReceive
    {
        public static object receiveObject()
        {
            object obj = new MdlDisplayUserInfo(1, "장진", 1, "1602spam@naver.com", "010-3758-6015");
            KeyValuePair<int, object> kvp = new KeyValuePair<int, object>( 1, obj );
            Distributor.Instance.recieveQueue.Enqueue(kvp);
            //"데이터 수신 시" 이벤트가 발생하면 distributor while함수에서 돌림
            Console.WriteLine("enqueued the received object in the distributor queue.");
            int i;
            for (i = 0; i < Distributor.Instance.recieveQueue.Count; i++)
                Console.WriteLine(i+1+"개의 데이터 수신");
            return obj;
        }
    }
}
