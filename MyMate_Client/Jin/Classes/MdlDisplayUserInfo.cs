using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page.Models
{
	public class MdlDisplayUserInfo
	{
		public int? UserCode { get; set; }
		public string? Username { get; set; }
		public int? Status { get; set; }
		public string? EmailAddress { get; set; }
		public string? PhoneNumber { get; set; }

		public MdlDisplayUserInfo()
		{
		}

		public MdlDisplayUserInfo(int userCode, string username, int status, string emailAddress, string phoneNumber)
		{
			UserCode = userCode;
			Username = username;
			Status = status; // == isOnline
			EmailAddress = emailAddress;
			PhoneNumber = phoneNumber;
		}

		public bool isValidate()
		{
			if (UserCode == null || Username == null || Status == null || EmailAddress == null || PhoneNumber == null)
				return false;
			else
				return true;
		}
	}
}