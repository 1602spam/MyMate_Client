﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page.Models
{
	public class MdlDisplayUserInfo
	{
        public int UserCode { get; set; }
		public string Username { get; set; }
		public int Status { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
	}
}