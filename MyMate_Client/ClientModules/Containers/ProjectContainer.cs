using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Containers
{
    public class ProjectContainer
    {
        public ConcurrentDictionary<int, MdlProject> Items = new();

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

        private static ProjectContainer? instance;
        public static ProjectContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectContainer();
                }
                return instance;
            }
        }

        private ProjectContainer()
        {
        }

        public void AddOrUpdate(MdlProject v)
        {
            if (v.nullCheck() == false)
            {
                this.Items.AddOrUpdate(Items.Count, v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent();
            }
            else
            {
                if (this.errorEvent != null)
                    this.errorEvent();
            }
        }

        public void GetItems(int projectCode)
        {
            MdlProject? pj;
            pj = this.Items.Values.FirstOrDefault(MdlProject => MdlProject.Code == projectCode);

            if (pj == null)
            {
#if DEBUG
                Console.WriteLine("해당하는 프로젝트코드의 프로젝트를 찾지 못함");
#endif
                return;
            }
            foreach (var v in pj.Items.Items)
            {
                Console.WriteLine(v.Title);
            }
        }
    }
}