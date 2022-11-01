using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Chat
{
    public class MdlPermission
    {
        //권한 코드
        public int Code { get; set; }
        //권한 이름
        public string Name { get; set; }
        //작은 단위의 클래스가 상위 단위의 코드를 가지고 알아서 붙게 함
        public bool nullCheck()
        {
            do
            {
                if (Code != 0)
                    break;
                if (Name != "")
                    break;
                return true;
            } while (false);

            return false;
        }
    }
}
