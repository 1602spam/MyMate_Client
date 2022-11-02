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

        private ServerContainer()
        {
        }

        public void AddOrUpdate(MdlServer v)
	    {
            if (v.nullCheck() == false)
            {
                this.Dict.AddOrUpdate(Dict.Count, v);
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