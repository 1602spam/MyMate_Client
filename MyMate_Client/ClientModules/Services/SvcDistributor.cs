using ClientToServer;
using Protocol;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcdResult = System.Collections.Generic.KeyValuePair<byte, object?>;

using ClientModules.Containers;
using ClientModules.Extensions;
using ClientModules.Models;
using ClientModules.Models.Calendar;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
using System.Xml.Linq;

namespace ClientModules.Services
{

	public sealed class SvcDistributor
	{
		private List<byte>? bytes;
		private RcdResult result;

		// 싱글턴 구현
		// Distributor.Instance.~~~로 접근합니다.
		// 클래스 안에 static 멤버 속성은 프로그램 메모리 적재 시에 구성
		private static SvcDistributor instance;
		public static SvcDistributor Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SvcDistributor();
					//Console.WriteLine("distributor 실행됨");
				}
				return instance;
			}
		}
		private SvcDistributor()
		{
			// 수신 큐에 KeyValuePair가 들어오면 읽어서 해당 오브젝트 큐로 전송하도록 taskDistributor 이벤트 등록

			// 이벤트 정리
			// 1. 대리자 선언
			// 2. 대리자 형식 이벤트 속성 선언
			// 3. 작업을 수행할 객체에서 대리자 형식 이벤트에 메서드 추가
			// 4. 이벤트 호출하면 해당 메서드가 실행됨

			Server.Instance.ReceiveEvent += TaskDistributor;
		}

		private static void TaskDistributor()
		{
			if (!Server.Instance.IsEmpty())
			{
				// 데이터를 읽어옴
				Server.Instance.Receive(out Instance.bytes);
				Instance.result = Converter.Convert(Instance.bytes);

				// 읽어온 데이터가 없다면 Continue
				if (null != Instance.result.Value)
#pragma warning disable CS8620 // 참조 형식의 null 허용 여부 차이로 인해 매개 변수에 대해 인수를 사용할 수 없습니다.
					EstimateObject(Instance.result);
#pragma warning restore CS8620 // null check if문을 사용했으므로/정상적인 값이 전송되는 경우만 고려하므로 무시함
			}
		}

        public void PutUser(MdlUser v)
		{
            UserContainer.Instance.AddOrUpdate(v.Code, v);
        }
        public void PutSchedule(MdlSchedule v)
		{
			ScheduleContainer.Instance.AddOrUpdate(v);
		}
		public void PutScheduleItem(MdlScheduleItem v)
		{
            /*
			 * 스케줄 컨테이너 인스턴스에서
			 * 인수로 받은 항목이 참조하는 스케줄 코드를 가진 스케줄을 찾아서
			 * 그 안의 스케줄 항목 컨테이너에 스케줄 항목을 넣어줌
			 */
            MdlSchedule? s;

			//
            s = ScheduleContainer.Instance.Items.Values.FirstOrDefault(MdlSchedule => MdlSchedule.Code == v.ScheduleCode);
            if (s == null)
            {
#if DEBUG
                Console.WriteLine("ScheduleItem의 ScheduleCode와 일치하는 Schedule을 찾지 못함");
#endif
                return;
            }
            s.Items.AddOrUpdate(v);
        }
		public void PutProject(MdlProject v)
		{
			ProjectContainer.Instance.AddOrUpdate(v);
		}
		public void PutProjectItem(MdlProjectItem v)
		{
			MdlProject? p;

			p = ProjectContainer.Instance.Items.Values.FirstOrDefault(MdlProject => MdlProject.Code == v.Code);
			if (p == null)
            {
#if DEBUG
                Console.WriteLine("ProjectItem의 ProjectCode와 일치하는 Project를 찾지 못함");
#endif
                return;
            }
            p.Items.AddOrUpdate(v);
		}
        public void PutServer(MdlServer v)
        {
			ServerContainer.Instance.AddOrUpdate(v);
        }

        public void PutFriend(MdlFriend v)
        {
            FriendContainer.Instance.AddOrUpdate(v);
        }

        public void PutChatroom(MdlChatroom v)
		{
			MdlServer? s;

			s = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == v.ServerCode);
			if (s == null)
			{
#if DEBUG
				Console.WriteLine("Chatroom의 ServerCode와 일치하는 Server를 찾지 못함");
#endif
				return;
			}
			s.Chatrooms.AddOrUpdate(v);
        }

        public void PutMessage(MdlMessage v)
        {
			MdlServer? s;
			MdlChatroom? c;

			s = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == v.ServerCode);
			if (s == null)
            {
#if DEBUG
                Console.WriteLine("Chatroom의 ServerCode와 일치하는 Server를 찾지 못함");
#endif
				return;
            }
            c = s.Chatrooms.Items.FirstOrDefault(MdlChatroom => MdlChatroom.Code == v.ChatroomCode);
			if (c == null)
            {
#if DEBUG
                Console.WriteLine("Server 내에서 ChatroomCode와 일치하는 Chatroom을 찾지 못함");
#endif
				return;
            }
            c.Messages.AddOrUpdate(v);
        }

		

		private static void EstimateObject(KeyValuePair<byte, object> temp)
		{
			//테스트
			switch (temp.Key)
			{
                case DataType.MESSAGE:
                    {
                        MessageProtocol.MESSAGE? message;
                        message = temp.Value as MessageProtocol.MESSAGE;

                        SvcDistributor.instance.PutMessage(new MdlMessage(message));
#if DEBUG
                        Console.WriteLine("메시지 프로토콜을 수신하고 분배 시도");
#endif
                    }
                    break;
                
				case DataType.USER:
					{
						UserProtocol.USER? user;
						user = temp.Value as UserProtocol.USER;
                        MdlMyself m = MdlMyself.Instance;

                        MdlUser u = new(user);
						if (user.userCode == m.Code)
						{
							m.SetProperty(u.Code, u.ID ,u.Name, u.Username, u.Email, u.PhoneNumber, u.Introduction, u.RecentTime);
                            return;
						}

						SvcDistributor.Instance.PutUser(u);
					}
					break;

				case DataType.LOGINUSER:
					{
						LoginUserProtocol.LOGINUSER? me;
						me = temp.Value as LoginUserProtocol.LOGINUSER;

						//프로토콜에서 Get으로 각 속성을 받아 내 정보 속성을 설정
						MdlMyself m = MdlMyself.Instance;
						int code = 0;
						string id = "";
						string name = "";
						string username = "";
						string email = "";
						string phonenumber = "";
						string introduction = "";
						DateTime dateTime = DateTime.Now;

						me.Get(out code, out id, out name, out username, out email, out phonenumber, out introduction, out dateTime);
						if (code == 0)
						{
							return;
						}
						m.SetProperty(code, id, name, username, email, phonenumber, introduction, dateTime);
					}
					break;

				case DataType.CHNNEL:
					{
						ChannelProtocol.CHNNEL? channel;
						channel = temp.Value as ChannelProtocol.CHNNEL;

						if (channel == null)
							break;
                        switch(channel.state)
						{
							case ChannelType.Calender:

                                {									
									SvcDistributor.instance.PutSchedule(new MdlSchedule(channel));
								}
								break;
							case ChannelType.Message:
								{
									SvcDistributor.instance.PutChatroom(new MdlChatroom(channel));
								}
								break;
							case ChannelType.Project:
								{
									SvcDistributor.instance.PutProject(new MdlProject(channel));
								}
								break;
							default:
								break;
						}
                    }
                    break;
					
				case DataType.CALENDER:
					{
						CalenderProtocol.CALENDER? scheduleItem;
						scheduleItem = temp.Value as CalenderProtocol.CALENDER;
						
						SvcDistributor.instance.PutScheduleItem(new MdlScheduleItem(scheduleItem));
					}
					break;
				
					
				case DataType.SERVER:
					{
						ServerProtocol.Server? server;
						server = temp.Value as ServerProtocol.Server;
						
						SvcDistributor.instance.PutServer(new MdlServer(server));
					}
					break;
					
				case DataType.CHECKLIST:
					{
						CheckListProtocol.CHECKLIST? projectitem;
						projectitem = temp.Value as CheckListProtocol.CHECKLIST;
						
						SvcDistributor.instance.PutProjectItem(new MdlProjectItem(projectitem));
					}
					break;

				case DataType.FRIEND:
					{
						FriendProtocol.FRIEND? friend;
						friend = temp.Value as FriendProtocol.FRIEND;

						SvcDistributor.instance.PutFriend(new MdlFriend(friend));
					}
					break;
				
                default:
					Console.WriteLine("알 수 없는 데이터를 수신하고 딕셔너리에는 저장하지 않았습니다.");
					break;
			}
		}
	}
}
