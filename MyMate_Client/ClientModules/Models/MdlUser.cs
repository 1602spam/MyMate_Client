using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClientModules.Containers;
using Protocol;

namespace ClientModules.Models
{
    public class MdlUser
    {
        //유저 코드
        public int Code { get; set; }
        //유저 로그인 시 사용하는 ID
        public string ID { get; set; }
        //유저 실제 이름
        public string Name { get; set; }

        private string userName;
        //유저 별명
        public string Username
        {
            get
            {
                //친구 목록에 있는지 확인해서 있다면 해당 친구 설정한 이름 반환
                MdlFriend? f = FriendContainer.Instance.Items.Values.FirstOrDefault(MdlFriend => MdlFriend.FriendCode == this.Code);
                if (f != null)
                    return f.Nickname;
                else
                    return this.userName;
            }
            set
            {
                userName = value;
            }
        }
        //유저 상태
        //public int Status { get; set; }

        //유저 E-mail 주소
        public string Email { get; set; }
        //유저 연락처
        public string PhoneNumber { get; set; }
        //유저 자기소개
        public string Introduction { get; set; }
        //최근 패킷 받은 시간
        public DateTime RecentTime { get; set; }

        public MdlUser(int code, string id, string name, string username, string email, string phonenumber, string introduce)
        {
            this.Code = code;
            this.ID = id;
            this.Name = name;
            this.Username = username;
            this.Email = email;
            this.PhoneNumber = phonenumber;
            this.Introduction = introduce;
        }

        public MdlUser() { }
        public MdlUser(UserProtocol.USER user)
        {
            this.Code = user.userCode;
            //this.ID = user.id;
            this.Name = user.name;
            this.Username = user.nickname;
            this.Email = user.email;
            this.PhoneNumber = user.phone;
            this.Introduction = user.content;
            //this.RecentTime = user.recentTime;
        }

        public bool nullCheck()
        {
            return Code == 0 ? true : false;
        }
    }
}