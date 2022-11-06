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
	public class MdlMyself:MdlUser
	{
        private MdlMyself()
		{
		}

		public void SetProperty(int code, string name, string username, string email, string phonenumber, string introduction) {
			this.Code = code;
			this.Name = name;
			this.Username = username;
			this.Email = email;
			this.PhoneNumber = phonenumber;
			this.Introduction = introduction;
		}

        private static MdlMyself? instance;
        public static MdlMyself Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MdlMyself();
                }
                return instance;
            }
        }

		public bool NullCheck()
		{
			return Code == 0;
		}
	}
}