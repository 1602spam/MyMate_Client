using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Services
{
    public class SvcThread
    {
        public static void initializeThreads()
        {
            Thread t1 = new Thread(SvcDistributor.taskDistributor);
            t1.IsBackground = true;
            t1.Start();
        }
    }
}
