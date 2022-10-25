using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Friend
{
    public class MdlFriendList
    {
        //대상 유저의 코드
        public int Code { get; set; }
        //대상 유저의 친구 유저 코드 목록
        public List<int> Users { get; set; }
    }
}