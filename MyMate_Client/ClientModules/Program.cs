// See https://aka.ms/new-console-template for more information
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
            new(30,true,"���� 1",1),
            new(60,false,"���� 2",1)
        };
        List<MdlChatroom> crs = new()
        {
            new(6,30,"���� 1�� ä�ù� 1"),
            new(7,30,"���� 1�� ä�ù� 2"),
            new(8,60,"���� 2�� ä�ù� 1"),
            new(9,60,"���� 2�� ä�ù� 2"),
        };
        List<MdlMessage> msgs = new();
        for (i = 0; i < 10; i++) {
            msgs.Add(new(i, 30, 6, 1, "���� ���� 1�� �޽��� " + i.ToString(), DateTime.Now));
            msgs.Add(new(i, 60, 6, 1, "���� ���� 2�� �޽��� " + i.ToString(), DateTime.Now));
        }
        for (i = 0; i < svs.Count; i++)
        {
            SvcDistributor.Instance.putServer(svs[i]);
        }
        for (i = 0; i < crs.Count; i++)
        {
            SvcDistributor.Instance.putChatroom(crs[i]);
        }
        for (i = msgs.Count - 1; i >= 0; i--)
        {
            SvcDistributor.Instance.putMessage(msgs[i]);
        }


    }
    return;
}