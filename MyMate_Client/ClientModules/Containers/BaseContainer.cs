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
    public class BaseContainer
    {
        public int Count { get; set; }
        public int GenerateKey()
        {
            return this.Count++;
        }
    }
}