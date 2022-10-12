using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeji.Chatting
{
	public class Chat
	{
		public bool isMe;
		public string context;
		public string name;
		public string nickname;
		public DateTime date;

		public Chat(bool isMe, string context, string name, string nickname, DateTime date)
		{
			this.isMe = isMe;
			this.context = context;
			this.name = name;
			this.nickname = nickname;
			this.date = date;
		}
	}
}
