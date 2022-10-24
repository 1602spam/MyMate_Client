using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Classes
{
    public class MdlChatroom
    {
        public int? Code { get; set; }
        public int? ServerCode { get; set; }
        public string? Title { get; set; }

        //주체: 서버에 속한 채팅방 - 해당 서버에 속한 유저들에게 리스트로 표시됨
        //주체: 개인 채팅방       - 채팅방에 속한 유저들에게 단일 채팅방으로 표시됨

        //개인 채팅방은 단일 채팅방을 가진 서버라고 보고,
        //서버에는 IsCompact bool 값을 넣어서 구분해 표시하면 될 것 같아요.
        //앞으로는 개인 채팅방을 Compact Server라고 부르기로 합시다.

        //Compact Server에 속하거나 일반 Server에 속하기 때문에 동일한 구조로 구성합니다.
    }
}
