// See https://aka.ms/new-console-template for more information
using ClientModules.Classes;
using ClientModules.Services;
using ClientModules.Controllers;
using Client_to_Server;
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

MdlSignInInfo signininfo = new();

Server server = Server.Instance;
SvcDistributor d = SvcDistributor.Instance;