using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Protocol;

namespace ClientModules.Models
{
	public class MdlFriend
	{
		//관계 대상 유저 코드
		public int FriendCode { get; set; }
		//유저 별명
		public string Nickname { get; set; }
		//유저 연락처
		public bool IsBlocked { get; set; }
		//유저 자기소개
		public bool IsHidden { get; set; }

        public MdlFriend(int targetusercode, string nickname, bool isblocked, bool ishidden)
        {
			FriendCode = targetusercode;
			Nickname = nickname;
			IsBlocked = isblocked;
			IsHidden = ishidden;
        }

        public MdlFriend(FriendProtocol.FRIEND friend)
		{
			FriendCode = friend.friendCode;
			Nickname = friend.nickname;
			IsBlocked = friend.isBlock;
			IsHidden = friend.isHide;
		}

		public bool nullCheck()
		{
			return FriendCode == 0 ? true : false;
		}
	}
}