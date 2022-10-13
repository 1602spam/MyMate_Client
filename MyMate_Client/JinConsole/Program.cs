// See https://aka.ms/new-console-template for more information
using ClientNetwork;
using JinConsole.Unused;
using Page.Models;
using Protocol;
using Protocol.Protocols;
using System.Security.Cryptography;

MdlSignInUserInfo signinuserinfo = new();

List<byte> bytes;
Server server = Server.Instance;
SvcDistributor d = SvcDistributor.Instance;

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