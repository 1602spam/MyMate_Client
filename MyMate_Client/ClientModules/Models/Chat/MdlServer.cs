using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientModules.Classes;

namespace ClientModules.Models.Chat
{
    public class MdlServer
    {
        //서버 코드
        public int? Code { get; set; }
        //서버를 단일 채팅방으로 표시할지 여부
        public bool IsCompact { get; set; }
        //서버 제목
        public string Title { get; set; }
        //권한 코드 목록
        public List<int> PermissionCode { get; set; }
        //<권한 키, 유저코드>로 구성된 유저 목록
        public Dictionary<int, int> Users { get; set; }
        //생성자 코드
        public int OwnerCode { get; set; }
    }
}
