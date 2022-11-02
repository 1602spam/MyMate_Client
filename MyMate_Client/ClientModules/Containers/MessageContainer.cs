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
		public LinkedList<MdlMessage> List = new();

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
                if (this.errorEvent != null)
                {
                    this.errorEvent();
                    return;
                }

            //데이터가 없는 경우 무조건 넣고 리턴
            if (List.Count == 0) {
				List.AddLast(v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent();
                return;
            }

			//1일 날짜
            TimeSpan t = new TimeSpan(1, 0, 0, 0);  //1일
            DateTime d = DateTime.Now - t;          //오늘 날짜 - 1일 == 어제
            int i = List.Count - 1;                 //인덱스

            //어제 날짜보다 i번째 노드의 시간값이 최근일 때
            while (d < List.ElementAt(i).Time)
			{
				//동일한 코드를 가진 노드가 있다면
				if (List.ElementAt(i).Code == v.Code)
				{
					//대체하고 이벤트 처리 후 리턴
					List.AddAfter(List.Find(List.ElementAt(i)),v);
					List.Remove(List.ElementAt(i));
                    if (this.dataDistributedEvent != null)
                        this.dataDistributedEvent();
					return;
				}
				//없다면 이전 노드 탐색
				i--;
			}
			//다 뒤졌는데 없다면 마지막에 넣음
			List.AddLast(v);
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent();
			return;
        }
	}
}