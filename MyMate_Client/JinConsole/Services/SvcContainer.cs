using Jin.Classes;
using JinConsole.Unused;
using Page.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinConsole.Services
{
    public class SvcContainer
    {
        public ConcurrentBag<MdlDisplayUserInfo> ColDisplayUserInfo = new();

        static private SvcContainer? instance;
        static public SvcContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SvcContainer();
                }
                return instance;
            }
        }

    }
}
