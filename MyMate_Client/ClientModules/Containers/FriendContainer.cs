using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Chat;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
    public class FriendContainer:IContainer
    {
        public ConcurrentDictionary<int, MdlFriend> Items = new();

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

        private static FriendContainer? instance;
        public static FriendContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FriendContainer();
                }
                return instance;
            }
        }

        private FriendContainer()
        {
        }

        public void AddOrUpdate(MdlFriend v)
	    {
            if (v.nullCheck() == false)
            {
                this.Items.AddOrUpdate(Items.Count, v);
#if DEBUG
                MdlUser? u = UserContainer.Instance.Items.Values.FirstOrDefault(MdlUser => MdlUser.Code == v.FriendCode);
                if (u == null)
                {
                    if (this.errorEvent != null)
                        this.errorEvent();
                    return;
                }
                Console.WriteLine("친구 추가됨: "+u.Name);
#endif
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
            }
            else
            {
                if (this.errorEvent != null)
                    this.errorEvent();
            }
        }

        public List<MdlFriend> GetFriends()
        {
            List<MdlFriend> friends = new();
            if (this.Items != null)
            {
                foreach (var item in this.Items.Values) {
                    friends.Add(item);
                }
            }
            return friends;

        }
    }
}