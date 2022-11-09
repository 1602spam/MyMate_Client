using Protocol;
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
        //속한 서버 코드
        public int ServerCode { get; set; } 
        //프로젝트 코드
        public int ProjectCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //제목
        public string Content { get; set; }
        //완료 여부
        public bool IsChecked { get; set; }
        public bool IsDeleted { get; set; }
        public MdlProjectItem(int code, int projectCode, string content, bool isDone)
        {
            Code = code;
            ProjectCode = projectCode;
            Content = content;
            IsChecked = isDone;
        }

        public MdlProjectItem(CheckListProtocol.CHECKLIST chk)
        {
            this.Code = chk.checkListCode;
            this.ServerCode = chk.serverCode;
            this.ProjectCode = chk.channelCode;
            this.StartDate = chk.startDate;
            this.EndDate = chk.endDate;
            this.IsChecked = chk.isChecked;
        }

        public bool nullCheck()
        {
            do
            {
                if (Code != 0)
                    break;
                if (ProjectCode != 0)
                    break;
                if (Content != "")
                    break;
                return true;
            } while (false);

            return false;
        }
    }
}
