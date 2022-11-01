﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Protocol;

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
		public string Introduction { get; set; }
        public List<int> Friends { get; set; }
        
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
			Introduction = introduce;
        }

        public MdlUser(UserInfoProtocol.User user)
		{
			//attribute = user.attribute
		}

		public bool nullCheck()
		{
			return Code == 0 ? true : false;
		}
	}
}