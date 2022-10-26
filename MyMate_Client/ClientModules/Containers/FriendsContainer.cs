using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Models.Friend;
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
    public static class FriendsContainer
    {
        public static ConcurrentDictionary<int, MdlFriends> Dict = new();

        public static void AddOrUpdate(int k, MdlFriends v)
        {
            Dict.AddOrUpdate(k, v);
        }
    }
}