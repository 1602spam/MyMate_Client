﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.CheckList
{
    public class MdlProject
    {
        public int Code { get; set; }
        public int ServerCode { get; set; }
        public int OwnerCode { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int TargetPermission { get; set; }
        //대상 권한
        public Dictionary<int, string> Users { get; set; }
        //대상 서버에서 대상 권한을 가진 유저 목록을 가져와 직함과 참여 여부를 설정하고 저장하는데
        //이 때 유저코드, 직함 딕셔너리가 생성됨
    }
}