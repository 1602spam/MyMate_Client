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
    public class PermissionContainer
    {
        public ConcurrentDictionary<int, MdlPermission> Items = new();

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

        public void AddOrUpdate(MdlPermission v)
        {
            if (v.nullCheck() == false)
            {
                this.Items.AddOrUpdate(Items.Count, v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent();
            }
            else
            {
                if (this.errorEvent != null)
                    this.errorEvent();
            }
        }
    }
}