using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
    public delegate void distribute();
    public delegate void error();
    public interface IContainer
    {
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
    }
}
