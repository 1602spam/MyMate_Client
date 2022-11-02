using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.CheckList
{
    public class MdlProjectItem
    {
        //체크리스트 항목 코드
        public int Code { get; set; }
        //프로젝트 코드
        public int ProjectCode { get; set; }
        //담당자 유저 코드
        public int ManagerCode { get; set; }
        //제목
        public string Title { get; set; }
        //완료 여부
        public bool IsDone { get; set; }

        public MdlProjectItem(int code, int projectCode, int managerCode, string title, bool isDone)
        {
            Code = code;
            ProjectCode = projectCode;
            ManagerCode = managerCode;
            Title = title;
            IsDone = isDone;
        }

        public bool nullCheck()
        {
            do
            {
                if (Code != 0)
                    break;
                if (ProjectCode != 0)
                    break;
                if (ManagerCode != 0)
                    break;
                if (Title != "")
                    break;
                return true;
            } while (false);

            return false;
        }
    }
}
