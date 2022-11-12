using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Chat;
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
    public class ServerContainer:IContainer
    {
        public ConcurrentDictionary<int, MdlServer> Items = new();

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

        private static ServerContainer? instance;
        public static ServerContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServerContainer();
                }
                return instance;
            }
        }

        private ServerContainer()
        {
        }

        public void AddOrUpdate(MdlServer v)
	    {
            if (v.nullCheck() == false)
            {
                this.Items.AddOrUpdate(Items.Count, v);
#if DEBUG
                Console.WriteLine("서버 추가됨: "+v.Title);
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

        public List<MdlMessage>? GetMessages(int serverCode, int chatroomCode, int count)
        {
            MdlServer? server = GetServer(serverCode);
            if (server == null)
            {
#if DEBUG
                Console.WriteLine("해당하는 서버코드의 서버를 찾지 못함");
#endif
                return null;
            }

            return server.Chatrooms.GetMessages(chatroomCode, count);
        }

        public MdlChatroom? GetChatroom(int serverCode, int chatroomCode)
        {
            MdlServer? server = GetServer(serverCode);
            if (server == null)
            {
#if DEBUG
                Console.WriteLine("해당하는 서버코드의 서버를 찾지 못함");
#endif
                return null;
            }

            return server.Chatrooms.Items.FirstOrDefault(MdlChatroom => MdlChatroom.Code == chatroomCode);
        }

        public MdlServer? GetServer(int serverCode)
        {
            return this.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == serverCode);
        }
    }
}