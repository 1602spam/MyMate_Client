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
    public static class ScheduleContainer
    {
        public static ConcurrentDictionary<int, MdlSchedule> Dict = new();

        public static void AddOrUpdate(int k, MdlSchedule v)
        {
            Dict.AddOrUpdate(k, v);
        }
    }
}