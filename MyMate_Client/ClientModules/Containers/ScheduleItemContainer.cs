using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Calendar;
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
    public class ScheduleItemContainer : IContainer
    {
        public List<MdlScheduleItem> Items = new();

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

        public ScheduleItemContainer()
        {
        }

        public void AddOrUpdate(MdlScheduleItem v)
        {
            if (v.nullCheck() == true)
            {
#if DEBUG
                Console.WriteLine("스케줄 속성이 null");
#endif
                if (this.errorEvent != null)
                    this.errorEvent();
                return;
            }

            if (Items.Count == 0)
            {
#if DEBUG
                Console.WriteLine("최초 스케줄 추가됨: " + v.Title);
#endif
                Items.Add(v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
                return;
            }

            int i = Items.FindIndex(MdlScheduleItem => MdlScheduleItem.Code == v.Code);

            if (i != -1)
            {
#if DEBUG
                Console.WriteLine("스케줄 갱신: " + Items[i].Title + "->" + v.Title);
#endif
                Items.Insert(i, v);
                Items.RemoveAt(i + 1);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
                return;
            }

            Items.Add(v);
#if DEBUG
            Console.WriteLine("스케줄 추가됨: " + v.Title);
#endif
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent(v);
            return;
        }
    }
}