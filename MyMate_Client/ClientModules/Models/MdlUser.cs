using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Protocol.Protocols;

namespace ClientModules.Models
{
	public class MdlUser
	{
		//유저 코드
		public int Code { get; set; }
		//유저 실제 이름
		public string Name { get; set; }
		//유저 별명
		public string Username { get; set; }
		//유저 상태
		public int Status { get; set; }
		//유저 E-mail 주소
		public string Email { get; set; }
		//유저 연락처
		public string PhoneNumber { get; set; }
		//유저 자기소개
		public string Introduce { get; set; }

		public MdlUser()
		{
		}

        public MdlUser(int code, string name, string username, int status, string email, string phonenumber, string introduce)
        {
			Code = code;
			Name = name;
			Username = username;
			Status = status;
			Email = email;
			PhoneNumber = phonenumber;
			Introduce = introduce;
        }

        public MdlUser(UserInfoProtocol.User user)
		{
			Code = user.code;
			Name = user.name;
			Username = user.username;
			Status = user.status;
			Email = user.email;
			PhoneNumber = user.phone;
		}

		/*
		public bool nullCheck()
		{
			if (UserCode == null || Username == null || Status == null || EmailAddress == null || PhoneNumber == null)
				return true;
			else
				return false;
		}
		*/
	}
}