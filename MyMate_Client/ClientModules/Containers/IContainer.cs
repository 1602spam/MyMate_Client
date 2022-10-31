using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
    public delegate void distributed();
    public interface IContainer
    {
        public event distributed? dataDistributedEvent;
        public event distributed DataDistributedEvent
        {
            add => dataDistributedEvent += value;
            remove => dataDistributedEvent -= value;
        }
    }
}
