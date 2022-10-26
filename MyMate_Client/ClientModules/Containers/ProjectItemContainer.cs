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
    public static class ProjectItemContainer
    {
        public static ConcurrentDictionary<int, MdlProjectItem> Dict = new();

        public static void AddOrUpdate(int k, MdlProjectItem v)
        {
            Dict.AddOrUpdate(k, v);
        }
    }
}