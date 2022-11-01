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
			TimeSpan t = new TimeSpan(1, 0, 0, 0);	//1일
			DateTime d = DateTime.Now - t;			//오늘 날짜 - 1일 == 어제
			int i = List.Count - 1;					//인덱스

			if(v.nullCheck() == true)
			    if (this.errorEvent != null)
				{
					this.errorEvent();
					return;
				}

			while (d < List.ElementAt(i).Time) //어제 날짜보다 최근일 때
			{
				//동일한 코드를 가진 노드가 있다면
				if (List.ElementAt(i).Code == v.Code)
				{
					List.AddAfter(new LinkedListNode<MdlMessage>(List.ElementAt(i)),v); //대체하고
					List.Remove(List.ElementAt(i));
                    if (this.dataDistributedEvent != null)
                        this.dataDistributedEvent();
					return;
				}
				i--;
			}
			List.AddLast(v);
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent();
			return;
        }
	}
}