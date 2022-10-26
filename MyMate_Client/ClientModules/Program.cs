// See https://aka.ms/new-console-template for more information
using ClientModules.Classes;
using ClientModules.Services;
using ClientModules.Controllers;
using ClientNetwork;
using Protocol;
using Protocol.Protocols;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using ClientModules.Models;
using System.Runtime.CompilerServices;

MdlSignInInfo signininfo = new();

Server server = Server.Instance;
SvcDistributor d = SvcDistributor.Instance;

while (true)
{
    MdlUser user = new(1, "asdf", "asdf", 1, "asdf", "01011010101", "하이");
    SvcDistributor.Users.AddOrUpdate(user.Code, user);

    Thread.Sleep(5000);
    /*
    SignInController.enterSignInInfo(ref signininfo);
    SignInController.sendSignInRequest(signininfo);
    Thread.Sleep(5000);
    */
}