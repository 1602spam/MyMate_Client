using ClientModules.Containers;
using Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Models.Chat
{
	public class MdlChatroom
	{
		//채팅방 코드
		public int Code { get; set; }
		//채팅방이 속한 서버 코드(개인 채팅방을 Compact한 서버라고 가정)
		public int ServerCode { get; set; }
		//채팅방 이름(개인 채팅방의 경우 필요 없음)
		public string Title { get; set; }
		public MessageContainer Messages { get; set; }
		public MdlChatroom(int code, int serverCode, string title)
		{
			Code = code;
			ServerCode = serverCode;
			Title = title;
			Messages = new();
		}
		public MdlChatroom(ChannelProtocol.CHNNEL chatroom)
		{
			this.Code = chatroom.channelCode;
			this.ServerCode = chatroom.serverCode;
			this.Title = chatroom.title;
			this.Messages = new();
		}

		public bool nullCheck()
		{
			do
			{
				if (Code != 0)
					break;
				if (ServerCode != 0)
					break;
				if (Title != "")
					break;
				return true;
			} while (false);
			return false;
		}
	}
}
