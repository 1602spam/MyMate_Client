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
        public int? Code { get; set; }
        public bool IsCompact { get; set; }
        public string Title { get; set; }
        public Dictionary<int, int> UserCodes { get; set; }
        //<권한 키, 유저코드>로 구성된 유저 목록
        public int OwnerCode { get; set; }
    }
}