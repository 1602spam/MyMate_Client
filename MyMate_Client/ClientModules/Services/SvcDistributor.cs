using Client_to_Server;
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

namespace ClientModules.Services
{

	public sealed class SvcDistributor
	{
		private List<byte>? bytes;
		private RcdResult result;

		// 싱글턴 구현
		// Distributor.Instance.~~~로 접근합니다.
		// 클래스 안에 static 멤버 속성은 프로그램 메모리 적재 시에 구성
		private static SvcDistributor? instance;
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



			Server.Instance.ReceiveEvent += taskDistributor;
		}

		private static void taskDistributor()
		{
			if (!Server.Instance.IsEmpty())
			{
				// 데이터를 읽어옴
				Server.Instance.Receive(out Instance.bytes);
				Instance.result = Converter.Convert(Instance.bytes);

				// 읽어온 데이터가 없다면 Continue
				if (null != Instance.result.Value)
#pragma warning disable CS8620 // 참조 형식의 null 허용 여부 차이로 인해 매개 변수에 대해 인수를 사용할 수 없습니다.
					estimateObject(Instance.result);
#pragma warning restore CS8620 // null check if문을 사용했으므로/정상적인 값이 전송되는 경우만 고려하므로 무시함
			}
		}

		private static void estimateObject(KeyValuePair<byte, object> temp)
		{
			switch (temp.Key)
			{
				/*
				case DataType.USER:
					{
						UserProtocol.USER? user;
						user = temp.Value as UserProtocol.USER;

						MdlUser u = new(user);
						if(u.Code != null)
						{
							//유저코드/유저
							UserContainer.Instance.AddOrUpdate(u.Code, u);
						} else
							UserContainer.Instance.errorEvent();
					}
					break;
					
				case DataType.SCHEDULE:
					{
						ScheduleProtocol.Schedule? schedule;
						schedule = temp.Value as ScheduleProtocol.SCHEDULE;
						
						MdlSchedule s = new(schedule);
						if(s.Code != null)
						{
							ScheduleContainer.Instance.AddOrUpdate(s.Code, c);
						} else
							ScheduleContainer.Instance.errorEvent();
					}
					break;
					
				case DataType.SCHEDULEITEM:
					{
					}
					break;
				
				case DataType.CHATROOM:
					{
					}
					break;
					
				case DataType.MESSAGE:
					{
					}
					break;
				
				case DataType.PERMISSION:
					{
					}
					break;
					
				case DataType.SERVER:
					{
					}
					break;
					
				case DataType.PROJECT:
					{
					}
					break;
					
				case DataType.PROJECTITEM:
					{
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
