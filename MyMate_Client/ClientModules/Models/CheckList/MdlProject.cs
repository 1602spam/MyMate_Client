using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.CheckList
{
    public class MdlProject
    {
        //프로젝트 코드
        public int Code { get; set; }
        //서버 코드
        public int ServerCode { get; set; }
        //생성자 코드
        public int OwnerCode { get; set; }
        //프로젝트 제목
        public string Title { get; set; }
        //프로젝트 시작 일자
        public string StartDate { get; set; }
        //프로젝트 종료 일자
        public string EndDate { get; set; }
        //대상 권한
        public int TargetPermission { get; set; }
        //대상 서버에서 대상 권한을 가진 유저 목록을 가져와 직함과 참여 여부를 설정하고 저장하는데
        //이 때 유저코드, 직함 딕셔너리가 생성됨
        public Dictionary<int, string> Users { get; set; }
    }
}