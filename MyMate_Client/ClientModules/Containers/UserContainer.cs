using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Services;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
        public delegate void distributed();
	public class UserContainer
	{
        protected event distributed? dataDistributedEvent;
        public event distributed DataDistributedEvent
        {
            add => dataDistributedEvent += value;
            remove => dataDistributedEvent -= value;
        }

        public ConcurrentDictionary<int, MdlUser> Dict = new();

		public void AddOrUpdate(int k, MdlUser v)
		{
			this.Dict.AddOrUpdate(k, v);
            if (dataDistributedEvent != null)
                dataDistributedEvent();
        }

        private static UserContainer? instance;
        public static UserContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserContainer();
                }
                return instance;
            }
        }
    }
}