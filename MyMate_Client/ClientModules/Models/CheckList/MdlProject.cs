using ClientModules.Containers;
using Protocol;
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
        //대상 권한
        //public List<int> TargetPermission { get; set; }
        public ProjectItemContainer Items { get; set; }
        //대상 서버에서 대상 권한을 가진 유저 목록을 가져와 직함과 참여 여부를 설정하고 저장하는데
        //이 때 유저코드, 직함 딕셔너리가 생성됨
        public List<int> Users { get; set; }
        //public Dictionary<int, string> Users { get; set; }
        public bool IsDeleted { get; set; }
        public MdlProject(ChannelProtocol.CHNNEL channel)
        {
            this.Code = channel.channelCode;
            this.ServerCode = channel.serverCode;
            //테스트
            this.OwnerCode = MdlMyself.Instance.Code;
            //this.OwnerCode = channel.creator;
            this.Title = channel.title;
            this.Items = new ProjectItemContainer();
            this.Users = new();
            //this.Users = channel.users;
        }

        public bool nullCheck() {
            do
            {
                if (ServerCode != 0)
                    break;
                if (OwnerCode != 0)
                    break;
                if (Title != "")
                    break;
                //if (StartDate == 0)
                    return true;
            } while (false);

            return false;
        }
    }
}