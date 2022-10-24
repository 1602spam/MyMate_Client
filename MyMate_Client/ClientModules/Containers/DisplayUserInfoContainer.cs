using ClientModules.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
    public class DisplayUserInfoContainer
    {
        public int Count { get; set; }
        public ConcurrentDictionary<int, MdlDisplayUserInfo> Dictionary { get; set; }

        public DisplayUserInfoContainer() {
            Count = 0;
            Dictionary = new();
        }
    }
}