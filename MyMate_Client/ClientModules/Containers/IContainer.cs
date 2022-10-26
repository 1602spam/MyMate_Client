using Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
    public delegate void DataDistributed();
    public class IContainer
    {
        private event DataDistributed distributeEvent
        //public event DataDistributed DistributeEvent
        {
            add
            {
                distributeEvent += value;
            }
            remove
            {
                distributeEvent -= value;
            }
        }
    }
}
