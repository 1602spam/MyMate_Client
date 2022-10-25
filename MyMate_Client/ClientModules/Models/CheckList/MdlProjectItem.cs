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
    }
}
