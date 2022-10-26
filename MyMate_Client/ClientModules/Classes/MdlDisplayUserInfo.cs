using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Protocol.Protocols;

namespace ClientModules.Classes
{
	public class MdlDisplayUserInfo
	{
		public int? UserCode { get; set; }
        public string? ID { get; set; }

        public string? Name { get; set; }

        public string? Nick { get; set; }

        //public string? Username { get; set; }
        //public int? Status { get; set; }
		//public string? EmailAddress { get; set; }
		public string? PhoneNumber { get; set; }

		public MdlDisplayUserInfo()
		{
		}

        public MdlDisplayUserInfo(UserInfoProtocol.User user)
        {
            UserCode = user.code;
            ID = user.id;
            Name = user.name;
            Nick = user.nick;
            PhoneNumber = user.phone;
        }

        public MdlDisplayUserInfo(int userCode, string id, string name, string nick, string phoneNumber)
        {
            UserCode = userCode;
			ID = id;
			Name = name;
			Nick = nick;
            PhoneNumber = phoneNumber;
        }

        public bool nullCheck()
		{
            if (UserCode == null || ID == null || Name == null || Nick == null || PhoneNumber == null)
                return true;
            else
                return false;
        }

        /*
		public MdlDisplayUserInfo(int userCode, string username, int status, string emailAddress, string phoneNumber)
		{
			UserCode = userCode;
			Username = username;
			Status = status; // == isOnline
			EmailAddress = emailAddress;
			PhoneNumber = phoneNumber;
		}
		
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