// See https://aka.ms/new-console-template for more information
using ClientNetwork;
using JinConsole.Services;
using JinConsole.Unused;
using Page.Models;
using Protocol;
using Protocol.Protocols;
using System.Security.Cryptography;

MdlSignInUserInfo signinuserinfo = new();

ServerInfo server=ServerInfo.Instance;
List<byte> bytes;
SvcInitializer.initialize();

while (true)
{
    signinuserinfo.enterSignInInfo();
    signinuserinfo.sendSignInRequest();

    bytes = new();

    LoginProtocol.Login l = new(signinuserinfo.ID,signinuserinfo.PW);
    Generater.Generate(l,ref bytes);
    server.send.Data(bytes);
    Thread.Sleep(5000);
}
//receive에 이벤트 등록 v
//이벤트 내용: distributor에서 읽어서 recieveQueue.pop메서드를 사용해서 각 오브젝트를 Container에 등록
//Container의 내용을 검색해서 꺼내올 수 있음