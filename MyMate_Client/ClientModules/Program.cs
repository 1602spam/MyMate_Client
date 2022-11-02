// See https://aka.ms/new-console-template for more information
#define DEBUG

using ClientModules.Classes;
using ClientModules.Services;
using ClientModules.Controllers;
using ClientToServer;
using Protocol;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using ClientModules.Models;
using System.Runtime.CompilerServices;
using static Protocol.UserInfoProtocol;
using System.Collections.Generic;
using System.Reflection.Metadata;
using ClientModules.Containers;
using ClientModules.Models.Chat;

MdlLogIn signininfo = new();

//Server server = Server.Instance;
//SvcDistributor d = SvcDistributor.Instance;

while (true)
{
    int i;
    {
        List<MdlServer> svs = new()
        {
            new(30,true,"서버 1",1),
            new(60,false,"서버 2",1)
        };
        List<MdlChatroom> crs = new()
        {
            new(6,30,"서버 1의 채팅방 1"),
            new(7,30,"서버 1의 채팅방 2"),
            new(8,60,"서버 2의 채팅방 1"),
            new(9,60,"서버 2의 채팅방 2"),
            new(9,60,"서버 2의 채팅방 2 변경본"),
        };
        List<MdlMessage> msgs = new();
        for (i = 0; i < 5; i++) {
            msgs.Add(new(i, 30, 6, 1, "나는 서버 1의 메시지 " + i.ToString() + " " + DateTime.Now.ToString(), DateTime.Now));
            msgs.Add(new(i, 60, 8, 1, "나는 서버 2의 메시지 " + i.ToString() + " " + DateTime.Now.ToString(), DateTime.Now));
        }
        msgs.Add(new(4, 30, 6, 1, "이걸 수정해???????", DateTime.Now));
        Console.WriteLine("데이터 생성 완료");
        Console.WriteLine("수신 테스트");
        for (i = 0; i < svs.Count; i++)
        {
            SvcDistributor.Instance.putServer(svs[i]);
        }
        for (i = 0; i < crs.Count; i++)
        {
            SvcDistributor.Instance.putChatroom(crs[i]);
        }
        for (i = 0; i < msgs.Count; i++)
        {
            SvcDistributor.Instance.putMessage(msgs[i]);
        }
        Console.WriteLine("조회 테스트 1: 서버 1 채팅방 1에서 3개");
        ServerContainer.Instance.GetMessages(30, 6, 3);
        Console.WriteLine("조회 테스트 2: 존재하지 않는 서버");
        ServerContainer.Instance.GetMessages(1, 6, 3);
        Console.WriteLine("조회 테스트 3: 존재하지 않는 채팅방");
        ServerContainer.Instance.GetMessages(30, 66, 3);
        Console.WriteLine("조회 테스트 4: 과한 데이터 개수");
        ServerContainer.Instance.GetMessages(30, 6, 45645);
        Console.WriteLine("조회 테스트 5: 데이터 개수가 음수");
        ServerContainer.Instance.GetMessages(30, 6, -2);
    }
    return;
}