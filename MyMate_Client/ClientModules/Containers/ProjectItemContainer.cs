using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
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
    public class ProjectItemContainer
    {
        public List<MdlProjectItem> Items = new();

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

        public ProjectItemContainer()
        {
        }

        public void AddOrUpdate(MdlProjectItem v)
        {
            if (v.nullCheck() == true)
            {
#if DEBUG
                Console.WriteLine("프로젝트 아이템 속성이 null");
#endif
                if (this.errorEvent != null)
                    this.errorEvent();
                return;
            }

            if (Items.Count == 0)
            {
#if DEBUG
                Console.WriteLine("프로젝트 아이템 추가됨: " + v.Title);
#endif
                Items.Add(v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
                return;
            }

            int i = Items.FindIndex(MdlProjectItem => MdlProjectItem.Code == v.Code);

            if (i != -1)
            {
#if DEBUG
                Console.WriteLine("프로젝트 아이템 갱신: " + Items[i].Title + "->" + v.Title);
#endif
                Items.Insert(i, v);
                Items.RemoveAt(i + 1);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
                return;
            }

            Items.Add(v);
#if DEBUG
            Console.WriteLine("프로젝트 아이템 추가됨: " + v.Title);
#endif
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent(v);
            return;
        }
    }
}