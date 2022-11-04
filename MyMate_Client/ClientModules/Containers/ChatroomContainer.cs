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
    public class ChatroomContainer
    {
        public List<MdlChatroom> Items = new();

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

        public void AddOrUpdate(MdlChatroom v)
        {
            if (v.nullCheck() == true)
            {
#if DEBUG
                Console.WriteLine("채팅방 속성이 null");
#endif
                if (this.errorEvent != null)
                    this.errorEvent();
                return;
            }

            if (Items.Count == 0)
            {
#if DEBUG
                Console.WriteLine("최초 채팅방 추가됨: " + v.Title);
#endif
                Items.Add(v);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
                return;
            }

            int i = Items.FindIndex(MdlChatroom => MdlChatroom.Code == v.Code);

            if (i != -1)
            {
#if DEBUG
                Console.WriteLine("채팅방 갱신: " + Items[i].Title + "->" + v.Title);
#endif
                Items.Insert(i, v);
                Items.RemoveAt(i + 1);
                if (this.dataDistributedEvent != null)
                    this.dataDistributedEvent(v);
                return;
            }

            Items.Add(v);
#if DEBUG
            Console.WriteLine("채팅방 추가됨: " + v.Title);
#endif
            if (this.dataDistributedEvent != null)
                this.dataDistributedEvent(v);
            return;
        }

        public List<MdlMessage>? GetMessages(int chatroomCode, int count)
        {
            int j = 0;
            MdlChatroom? c;
            c = Items.FirstOrDefault(MdlChatroom => MdlChatroom.Code == chatroomCode);
            List<MdlMessage> mdlMessages = new();

            if (c == null)
            {
#if DEBUG
                Console.WriteLine("해당하는 채팅방코드의 채팅방을 찾지 못함");
#endif
                return null;
            }
            else
            {
                j = c.Messages.Items.Count;
                if (j != 0 && 0 < count && count < j)
                {
#if DEBUG
                    Console.WriteLine("메시지 불러오기 실행");
#endif
                    foreach (var item in c.Messages.Items.Reverse())
                    {
                        count--;
                        Console.WriteLine(item.Context);
                        mdlMessages.Add(item);
                        if (count == 0) { break; }
                    }
                    return mdlMessages;
                }
                else
                {
#if DEBUG
                    Console.WriteLine("유효하지 않은 데이터 개수");
#endif
                    return null;
                }
            }
        }
    }
}