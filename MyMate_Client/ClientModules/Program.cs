// See https://aka.ms/new-console-template for more information
using ClientModules.Classes;
using ClientModules.Services;
using ClientNetwork;
using Protocol;
using Protocol.Protocols;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;

MdlSignInUserInfo signinuserinfo = new();

Server server = Server.Instance;
SvcDistributor d = SvcDistributor.Instance;

while (true)
{
    signinuserinfo.enterSignInInfo();
    signinuserinfo.sendSignInRequest();
    Thread.Sleep(5000);
}