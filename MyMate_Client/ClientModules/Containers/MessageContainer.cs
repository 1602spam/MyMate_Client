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

		public event distributed? dataDistributedEvent;
		public event distributed DataDistributedEvent
		{
			add => dataDistributedEvent += value;
			remove => dataDistributedEvent -= value;
		}

		public void AddOrUpdate(MdlMessage v)
		{
			TimeSpan t = new TimeSpan(1, 0, 0, 0);	//1일
			DateTime d = DateTime.Now - t;			//오늘 날짜 - 1일 == 어제
			int i = List.Count - 1;					//인덱스

			while (d < List.ElementAt(i).Time) //어제 날짜보다 최근일 때
			{
				//코드가 같다면
				if (List.ElementAt(i).Code == v.Code)
				{
					List.AddAfter(new LinkedListNode<MdlMessage>(List.ElementAt(i)),v);
					List.Remove(List.ElementAt(i)); //대체
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