// See https://aka.ms/new-console-template for more information
using JinConsole.Services;
using JinConsole.Unused;
using Page.Models;

SvcContainer container = new();
MdlSignInUserInfo signinuserinfo = new();

SvcInitializer.initialize();

signinuserinfo.enterSignInInfo();
signinuserinfo.sendSignInRequest();

