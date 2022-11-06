using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientModules.Classes;
using ClientModules.Containers;

namespace ClientModules.Models.Chat
{
    public class MdlServer
    {
        //서버 코드
        public int Code { get; set; }
        //서버를 개인 채팅방으로 표시할지 여부
        public bool IsCompact { get; set; }
        //서버 제목
        public string Title { get; set; }
        //채팅방 목록
        public ChatroomContainer Chatrooms { get; set; }
        //유저코드로 구성된 유저 목록
        public List<int> Users { get; set; }
        //생성자 코드
        public int OwnerCode { get; set; }

        public MdlServer(int code, bool isCompact, string title, int ownerCode)
        {
            Code = code;
            IsCompact = isCompact;
            Title = title;
            OwnerCode = ownerCode;
            Chatrooms = new();
            Users = new();
        }

        public bool nullCheck()
        {
            do
            {
                if (Code != 0)
                    break;
                if (Title != "")
                    break;
                if (OwnerCode != 0)
                    break;
                return true;
            } while (false);

            return false;
        }
    }
}
