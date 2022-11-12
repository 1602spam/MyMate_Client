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
    public class UserContainer : IContainer
    {
        public ConcurrentDictionary<int, MdlUser> Items = new();

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
        public void AddOrUpdate(int k, MdlUser v)
        {
            //널체크 통과 시
            if (v.nullCheck() == false)
            {
                //추가하고 분배 이벤트 처리 후 리턴
                this.Items.AddOrUpdate(k, v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
                return;
            }
            //통과하지 못했을 시 오류 이벤트 처리 후 리턴
            else
            {
                if (this.errorEvent != null)
                    this.errorEvent();
            }
        }
    }
}
