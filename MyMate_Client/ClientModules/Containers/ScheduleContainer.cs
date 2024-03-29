﻿using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Calendar;
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
    public class ScheduleContainer
    {
        public ConcurrentDictionary<int, MdlSchedule> Items = new();

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

        public ScheduleContainer()
        {
        }

        public void AddOrUpdate(MdlSchedule v)
        {
            if (v.nullCheck() == false)
            {
                this.Items.AddOrUpdate(v.Code, v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
            }
            else
            {
                if (this.errorEvent != null)
                    this.errorEvent();
            }
        }
        public void GetSchedules()
        {
        }
        public List<MdlScheduleItem>? GetScheduleItems(int scheduleCode)
        {
            List<MdlScheduleItem> items = new();
            MdlSchedule? sc;
            sc = this.Items.Values.FirstOrDefault(MdlSchedule => MdlSchedule.Code == scheduleCode);

            if (sc == null)
            {
#if DEBUG
                Console.WriteLine("해당하는 스케줄코드의 스케줄을 찾지 못함");
#endif
                return null;
            }
            foreach (var v in sc.Items.Items)
            {
                items.Add(v);
            }
            return items;
        }
    }
}