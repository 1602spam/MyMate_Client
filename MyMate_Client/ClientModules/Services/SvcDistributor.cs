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

            s = ScheduleContainer.Instance.Items.Values.FirstOrDefault(MdlSchedule => MdlSchedule.Code == v.Code);
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

        //private void putMessage(MdlMessage v)
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
                        MessageProtocol.Message? message;
                        message = temp.Value as MessageProtocol.Message;

                        SvcDistributor.instance.PutMessage(new MdlMessage(message));
#if DEBUG
                        Console.WriteLine("메시지 프로토콜을 수신하고 분배 시도");
#endif
                    }
                    break;
                /*
				case DataType.USER:
					{
						UserProtocol.USER? user;
						user = temp.Value as UserProtocol.USER;

						putUser(new MdlUser(user));
					}
					break;

				case DataType.SCHEDULE:
					{
						ScheduleProtocol.Schedule? schedule;
						schedule = temp.Value as ScheduleProtocol.SCHEDULE;
						
						putSchedule(new MdlSchedule(schedule));
					}
					break;
					
				case DataType.SCHEDULEITEM:
					{
						ScheduleItemProtocol.ScheduleItem? scheduleItem;
						scheduleItem = temp.Value as ScheduleProtocol.SCHEDULEITEM;
						
						putScheduleItem(new MdlScheduleItem(scheduleitem));
					}
					break;
				
				case DataType.CHATROOM:
					{
						ChatroomProtocol.Chatroom? chatroom;
						chatroom = temp.Value as ChatroomProtocol.CHATROOM;
						
						putChatroom(new MdlChatroom(chatroom));
					}
					break;
				
				case DataType.PERMISSION:
					{
						PermissionProtocol.Permission? permission;
						permission = temp.Value as PermissionProtocol.PERMISSION;
						
						MdlPermission s = new(permission);
						PermissionContainer.Instance.AddOrUpdate(s.Code, c);
					}
					break;
					
				case DataType.SERVER:
					{
						ServerProtocol.Schedule? server;
						server = temp.Value as ServerProtocol.SERVER;
						
						MdlServer s = new(server);
						ServerContainer.Instance.AddOrUpdate(s.Code, c);
					}
					break;
					
				case DataType.PROJECT:
					{
						ProjectProtocol.Schedule? project;
						project = temp.Value as ProjectProtocol.PROJECT;
						
						MdlProject s = new(project);
						ProjectContainer.Instance.AddOrUpdate(s.Code, c);
					}
					break;
					
				case DataType.PROJECTITEM:
					{
						ProjectItemProtocol.PROJECTITEM? projectitem;
						projectitem = temp.Value as ProjectItemProtocol.PROJECTITEM;
						
						MdlProjectItem s = new(projectitem);
						ProjectItemContainer.Instance.AddOrUpdate(s.Code, c);
					}
					break;
				*/
                default:
					Console.WriteLine("알 수 없는 데이터를 수신하고 딕셔너리에는 저장하지 않았습니다.");
					break;
			}
		}
	}
}
