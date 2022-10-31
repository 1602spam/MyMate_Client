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
    public class ServerContainer:IContainer
    {
        public ConcurrentDictionary<int, MdlServer> Dict = new();

        public event distributed? dataDistributedEvent;
        public event distributed DataDistributedEvent
        {
            add => dataDistributedEvent += value;
            remove => dataDistributedEvent -= value;
        }

        private static ServerContainer? instance;
        public static ServerContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServerContainer();
                }
                return instance;
            }
        }
        public void AddOrUpdate(int k, MdlServer v)
        {
            Dict.AddOrUpdate(k, v);
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent();
        }
    }
}