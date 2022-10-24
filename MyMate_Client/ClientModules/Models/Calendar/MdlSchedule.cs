using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Calendar
{
    public class MdlSchedule
    {
        public int Code { get; set; }
        public int ServerCode { get; set; }
        public int OwnerCode { get; set; }
        public string Title { get; set; }
        public Dictionary<int, int> Users { get; set; }
        //서버 내의 불특정 다수가 공유 메시지를 클릭해 공유받으면
        //공유를 받은 유저 정보는 <유저 코드, 스케줄 코드>로 저장되어 해당 스케줄에 대한 리퀘스트를 요청하게 됨
        //참여 정보를 따로 구성해 각 유저가 리퀘스트를 보내고, 그 때 Item과 객체를 보내는 식으로 재구성하기
    }
}
