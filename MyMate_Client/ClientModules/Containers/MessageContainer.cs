using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Chat;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
	public class MessageContainer
	{
        public LinkedListNode<MdlMessage>? Node;
		public LinkedList<MdlMessage> Items = new();

		public event distribute? dataDistributedEvent;
		public event distribute DataDistributedEvent
		{
			add => dataDistributedEvent += value;
			remove => dataDistributedEvent -= value;
		}

		public event error? errorEvent;
        public event error ErrorEvent
        {
            add => errorEvent += value;
            remove => errorEvent -= value;
        }

        public void AddOrUpdate(MdlMessage v)
        {
            //속성값 유효 검사해서 유효하지 않으면 이벤트 처리하고 리턴
            if (v.nullCheck() == true)
            {
#if DEBUG
                Console.WriteLine("속성이 null");
#endif
                if (this.errorEvent != null)
                {
                    this.errorEvent();
                    return;
                }
            }
            //데이터가 없는 경우 무조건 넣고 리턴
            if (Items.Count == 0) {
#if DEBUG
                Console.WriteLine("최초로 메시지 추가: " + v.Context);
#endif
                Items.AddLast(v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent();
                return;
            }

            //1일 날짜
            TimeSpan t = new TimeSpan(1, 0, 0, 0);  //1일
            DateTime d = DateTime.Now - t;          //오늘 날짜 - 1일 == 어제
            int i = Items.Count - 1;                //인덱스

            //뒤에서부터 찾음
            Node = Items.Find(Items.LastOrDefault(MdlMessage => MdlMessage.Code == v.Code));
            //교체
            if (Node != null)
            {
#if DEBUG
                Console.WriteLine("메시지 코드 중복 발견 및 교체: "+Node.Value.Context+"->"+v.Context);
#endif
                Items.AddAfter(Node, v);
                Items.Remove(Node);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent();
                return;
            }
#if DEBUG
            Console.WriteLine("메시지 추가됨: "+v.Context);
#endif
            //다 뒤졌는데 없다면 마지막에 넣음
            Items.AddLast(v);
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent();
            return;
        }
	}
}