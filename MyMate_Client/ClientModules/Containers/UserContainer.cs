using ClientModules.Extensions;
using ClientModules.Models;
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
    public class UserContainer : BaseContainer
    {
        public ConcurrentDictionary<int, MdlUser> Dictionary { get; set; }
        public UserContainer() {
            Count = 0;
            Dictionary = new();
        }
        public void AddOrUpdate(int k, MdlUser v)
        {
            this.Dictionary.AddOrUpdate(k, v);
        }
    }
}