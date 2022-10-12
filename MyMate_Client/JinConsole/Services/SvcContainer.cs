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
        MdlDisplayUserInfo signInUserInfo = new();
        ConcurrentBag<MdlDisplayUserInfo> mdlDisplayUserInfos = new();

        static private SvcDistributor? instance;
        static public SvcDistributor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SvcDistributor();
                }
                return instance;
            }
        }
    }
}
