﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Component.Tools;
using Core.Db.Repositories;
using Core.Models;
using Application.Site;


namespace Presentation.Consoles
{
    [Export]
    internal class Program
    {
        private static CompositionContainer _container;

        [Import]
        public IAccountSiteContract AccountContract { get; set; }
        [Import]
        public IUserSiteContract UserContract { get; set; }

        #region 主程序

        private static void Main(string[] args)
        {
            //初始化MEF组合容器
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Directory.GetCurrentDirectory()));
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            _container = new CompositionContainer(catalog);

            bool exit = false;
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入命令：0; 退出程序，功能命令：1 - n");
                    string input = Console.ReadLine();
                    if (input == null)
                    {
                        continue;
                    }
                    switch (input.ToLower())
                    {
                        case "0":
                            exit = true;
                            break;
                        case "1":
                            Method01();
                            break;
                        case "2":
                            Method02();
                            break;
                        case "3":
                            Method03();
                            break;
                        case "4":
                            Method04();
                            break;
                        case "5":
                            Method05();
                            break;
                        case "6":
                            Method06();
                            break;
                        case "7":
                            Method07();
                            break;
                        case "8":
                            Method08();
                            break;
                        case "9":
                            Method09();
                            break;
                        case "10":
                            Method10();
                            break;
                        case "11":
                            Method11();
                            break;
                        case "12":
                            Method12();
                            break;
                        case "13":
                            Method13();
                            break;
                        case "14":
                            Method14();
                            break;
                    }
                    if (exit)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    ExceptionHandler(e);
                }
            }
        }

        private static void ExceptionHandler(Exception e)
        {
            ExceptionMessage emsg = new ExceptionMessage(e);
            Console.WriteLine(emsg.ErrorDetails);
        }

        #endregion

        #region 功能方法

        private static void Method01()
        {
            Program program = _container.GetExportedValue<Program>();
            Console.WriteLine(program.AccountContract.GetType().FullName);
            LoginInfo loginInfo = new LoginInfo { Access = "gmfcn", Password = "123456", IpAddress="127.0.0.1" };
            OperationResult result = program.AccountContract.Login(loginInfo);
            Console.WriteLine(result.Message);
            Console.WriteLine();
        }

        private static void Method02()
        {
            Console.WriteLine(_container.GetExportedValue<IMemberRepository>().GetType());
        }

        private static void Method03()
        {
            Program program = _container.GetExportedValue<Program>();
            User user = new User();
            user.AddDate = DateTime.Now;
            user.eattribute1 = "123";
            user.IsDeleted = false;
            user.mdate = DateTime.Now;
            user.muser = "123";
            user.usercode = "65128042";
            user.userdepart = "123";
            user.useremail = "123";
            user.username = "lg";
            user.userpwd = "123";
            user.userstat = "123";
            user.usertel = "123";
            OperationResult result = program.UserContract.AddUser(user);
            Console.WriteLine(result.Message);
            Console.WriteLine();
        }

        private static void Method04()
        {
            Program program = _container.GetExportedValue<Program>();           
            OperationResult result = program.UserContract.QueryUser("65128042");
            User user = (User)result.AppendData;
            Console.WriteLine(user.useremail);
            Console.WriteLine();
        }

        private static void Method05()
        {
            Program program = _container.GetExportedValue<Program>();
            OperationResult result = program.UserContract.QueryUser("65128042");
            
            User user = (User)result.AppendData;
            user.userpwd = "456";
            program.UserContract.UpdateUser(user);
            Console.WriteLine(user.userpwd);
            Console.WriteLine();
        }

        private static void Method06()
        {
            throw new NotImplementedException();
        }

        private static void Method07()
        {
            throw new NotImplementedException();
        }

        private static void Method08()
        {
            throw new NotImplementedException();
        }

        private static void Method09()
        {
            throw new NotImplementedException();
        }

        private static void Method10()
        {
            throw new NotImplementedException();
        }

        private static void Method11()
        {
            throw new NotImplementedException();
        }

        private static void Method12()
        {
            throw new NotImplementedException();
        }

        private static void Method13()
        {
            throw new NotImplementedException();
        }

        private static void Method14()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}