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
    public class ScheduleContainer
    {
        public ConcurrentDictionary<int, MdlSchedule> Dict = new();

        public event distributed? dataDistributedEvent;
        public event distributed DataDistributedEvent
        {
            add => dataDistributedEvent += value;
            remove => dataDistributedEvent -= value;
        }

        private static ScheduleContainer? instance;
        public static ScheduleContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScheduleContainer();
                }
                return instance;
            }
        }
        public void AddOrUpdate(int k, MdlSchedule v)
        {
            Dict.AddOrUpdate(k, v);
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent();
        }
    }
}