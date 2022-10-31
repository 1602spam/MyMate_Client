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
    public class ProjectContainer
    {
        public ConcurrentDictionary<int, MdlProject> Dict = new();

        public event distributed? dataDistributedEvent;
        public event distributed DataDistributedEvent
        {
            add => dataDistributedEvent += value;
            remove => dataDistributedEvent -= value;
        }

        private static ProjectContainer? instance;
        public static ProjectContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectContainer();
                }
                return instance;
            }
        }
        public void AddOrUpdate(int k, MdlProject v)
        {
            Dict.AddOrUpdate(k, v);
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent();
        }
    }
}