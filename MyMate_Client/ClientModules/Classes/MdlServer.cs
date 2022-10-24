using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Classes
{
    public class MdlServer
    {
        public int? Code { get; set; }
        public bool IsCompact { get; set; }
        public string Title { get; set; }
        public int[] UserCodes { get; set; }

        //권한 리스트, <권한 키,유저코드>로 된 유저 목록
    }
}
