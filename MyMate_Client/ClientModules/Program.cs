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
using static Protocol.Protocols.UserInfoProtocol;
using System.Collections.Generic;
using System.Reflection.Metadata;
using ClientModules.Containers;

MdlSignInInfo signininfo = new();

Server server = Server.Instance;
SvcDistributor d = SvcDistributor.Instance;

while (true)
{
    //윈폼에 적용되는 형태는 특정 액트를 public method, 세부 동작을 private으로 모듈화해 dictionary에 직접 접근하지 못하도록 할 것
    MdlUser user = new(1, "asdf", "asdf", 1, "asdf", "01011010101", "하이");
    UserContainer.AddOrUpdate(user.Code, user);
    user = new(1, "asdf", "asdf", 1, "asdf", "01011010101", "난 변경되었습니다~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    UserContainer.AddOrUpdate(user.Code, user);
    user = new(2, "asdf", "asdf", 1, "asdf", "01011010101", "하이");
    UserContainer.AddOrUpdate(user.Code, user);
    user = new(3, "asdf", "asdf", 1, "asdf", "01011010101", "하이");
    UserContainer.AddOrUpdate(user.Code, user);

    for (int i = 4; i <= 10; i++)
    {
        user = new(i, "asdf", "asdf", 1, "asdf", "01011010101", $"나는 {i}번");
        UserContainer.AddOrUpdate(user.Code, user);
    }

    Console.WriteLine("유저 딕셔너리 데이터를 불러옵니다.");
    IEnumerable<MdlUser> tmp = UserContainer.Dict.Values;
    if (tmp != null)
        foreach (MdlUser _temp in tmp)
        {
            Console.WriteLine("유저코드:" + _temp.Code + "\t자기소개:" + _temp.Introduction);
        }
    Console.WriteLine("\n");

    Console.WriteLine("컨테이너 내의 딕셔너리 내의 오브젝트 속성을 통한 검색");
    Console.WriteLine("소개가 하이라고 되어있는 딕셔너리 데이터만을 불러옵니다.");
    tmp = UserContainer.Dict.Values.Where(MdlUser => MdlUser.Introduction == "하이");
    if (tmp != null)
        foreach (MdlUser _temp in tmp)
        {
            Console.WriteLine("유저코드:" + _temp.Code + "\t자기소개:" + _temp.Introduction);
        }

    Thread.Sleep(10000);
    /*
    SignInController.enterSignInInfo(ref signininfo);
    SignInController.sendSignInRequest(signininfo);
    Thread.Sleep(5000);
    */
}