// See https://aka.ms/new-console-template for more information
using ClientNetwork;
using JinConsole.Unused;
using Page.Models;
using Protocol;
using Protocol.Protocols;
using System.Security.Cryptography;

MdlSignInUserInfo signinuserinfo = new();

Server server = Server.Instance;
SvcDistributor d = SvcDistributor.Instance;

Thread t = new Thread(SvcDistributor.taskDistributor);
t.IsBackground = true;
t.Start();

while (true)
{
    signinuserinfo.enterSignInInfo();
    signinuserinfo.sendSignInRequest();
    Thread.Sleep(5000);
}