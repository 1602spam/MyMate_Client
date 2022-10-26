using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Services;
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
    public class UserContainer : IContainer
    {
        public static ConcurrentDictionary<int, MdlUser> Dict = new();

        public static void AddOrUpdate(int k, MdlUser v)
        {
            Dict.AddOrUpdate(k, v);
        }

        private static UserContainer? instance;
        public static UserContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserContainer();
                    //Console.WriteLine("distributor 실행됨");
                }
                return instance;
            }
        }
    }
}