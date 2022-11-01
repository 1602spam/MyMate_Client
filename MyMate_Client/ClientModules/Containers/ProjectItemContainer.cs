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
        public int Count {get; set;}
        public ConcurrentDictionary<int, MdlProjectItem> Dict = new();

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

        private ProjectItemContainer()
        {
            Count = 0;
        }

        public void AddOrUpdate(int k, MdlProjectItem v)
	    {
		if(v.nullCheck()==false){
			this.Dict.AddOrUpdate(k, v);
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent();
		} else
			if(this.errorEvent != null)
				this.errorEvent();
        }
    }
}