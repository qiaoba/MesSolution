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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GMF.Demo.Core.Data.Initialize;
using Component.Data;
using Core.Db.Context;
using System.Data.Entity.Validation;
using System.Data.Entity.SqlServer;


namespace Presentation.Consoles
{
    [Export]
    internal class Program
    {
        private static CompositionContainer _container;
        private static CompositionContainer _container2;
        private static AggregateCatalog catalog;
     //   [Import(RequiredCreationPolicy = CreationPolicy.NonShared)]
     //   public ContainerIn cin { get; set; }



        #region 主程序

        private static void Main(string[] args)
        {
            //初始化数据库，如果存在且模型改变，删除重新建
            DatabaseInitializer.DropCreateDatabaseIfModelChanges();

            //初始化MEF组合容器
            catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Directory.GetCurrentDirectory()));
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            _container = new CompositionContainer(catalog);
            _container2 = new CompositionContainer(catalog);
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
            var studentManager1 = _container.GetExportedValue<ContainerIn>();
            var studentManager2 = _container2.GetExportedValue<ContainerIn>();
            Console.WriteLine(object.ReferenceEquals(studentManager1, studentManager2));            
            var studentManager3 = _container.GetExportedValue<DbContext>();
            var studentManager4 = _container2.GetExportedValue<DbContext>();
            Console.WriteLine(object.ReferenceEquals(studentManager3, studentManager4));  
            
     
        }

        private static void Method02()
        {
            OperationResult result = _container.GetExportedValue<IUserSiteContract>().DeleteEntity("65128047");
            Console.WriteLine(result.Message);
        }

        //添加
        private static void Method03()
        {
            DateTime dt = new DateTime(2014,10,24,11,11,11);
            User user = new User();
            user.AddDate = dt;
            user.eattribute1 = "123";
            user.IsDeleted = false;
            user.mdate = dt;
            user.muser = "651280476512804765128047651280476512804765128047651280476512804765128047";
            user.usercode = "65128047";
            user.userdepart = "123";
            user.useremail = "123";
            user.username = "lg";
            user.userpwd = "123";
            user.userstat = "123";
            user.usertel = "123";

            try
            {
                Console.WriteLine(_container.GetExportedValue<IUserSiteContract>().AddEntity(user).Message);
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage);
            }
            
         
        }
        //删除
        private static void Method04()
        {

            OperationResult result = _container.GetExportedValueOrDefault<ContainerIn>().UserContract.DeleteEntity("65128047");
            Console.WriteLine(result.Message);
            Console.WriteLine();
        }

        //同步修改
        private static void Method05()
        {
            OperationResult result2 = _container.GetExportedValueOrDefault<ContainerIn>().UserContract.FindEntity("65128044");
            User user = (User)result2.AppendData;
            user.userpwd = "444";
            using (var mesContext=new MesContext()){
                mesContext.Database.ExecuteSqlCommand("update Users set userpwd='333' where usercode='65128044'");
            }
            OperationResult result = _container.GetExportedValueOrDefault<ContainerIn>().UserContract.UpdateEntity(user);
            Console.WriteLine(result.Message);
            Console.WriteLine();
        }
        //查询
        private static void Method06()
        {
            OperationResult result = _container.GetExportedValueOrDefault<ContainerIn>().UserContract.FindEntity("65128044");
            User user = (User)result.AppendData;
            Console.WriteLine(user.userpwd);
            Console.WriteLine();
        }

        private static void PrintChangeTrackingInfo(DbContext context, User entity)
        {
            var entry = context.Entry(entity);
            Console.WriteLine(entry.Entity.userpwd);
            Console.WriteLine("State: {0}", entry.State);

            Console.WriteLine("\nCurrent Values:");
            PrintPropertyValues(entry.CurrentValues);

            Console.WriteLine("\nOriginal Values:");
            PrintPropertyValues(entry.OriginalValues);

            Console.WriteLine("\nDatabase Values:");
            PrintPropertyValues(entry.GetDatabaseValues());
        }
        private static void PrintPropertyValues(DbPropertyValues values)
        {
            foreach (var propertyName in values.PropertyNames)
            {
                if (propertyName.ToString().Equals("userpwd"))
                    Console.WriteLine(" - {0}: {1}", propertyName, values[propertyName]);
            }
        }

        private static void Method07()
        {
            User user=new User();
            Type t = user.GetType();
            user.AddDate = DateTime.Now;
            user.eattribute1 = "123";
            user.IsDeleted = false;
            user.mdate = DateTime.Now;
            user.muser = "123";
            user.usercode = "65128047";
            user.userdepart = "123";
            user.useremail = "123";
            user.username = "lg";
            user.userpwd = "123";
            user.userstat = "123";
            user.usertel = "123";
           
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    object value1 = pi.GetValue(user, null);//用pi.GetValue获得值
                    string name = pi.Name;//获得属性的名字,后面就可以根据名字判断来进行些自己想要的操作
                    //获得属性的类型,进行判断然后进行以后的操作,例如判断获得的属性是整数  
                    if (value1== null)
                    {
                        continue;
                    }
                    if (value1.GetType() == typeof(string))
                    {
                        pi.SetValue(user, name, null);
                    }
                    if (value1.GetType() == typeof(DateTime))
                    {
                        pi.SetValue(user, DateTime.Now, null);
                    }
                    if (value1.GetType() == typeof(bool))
                    {
                        pi.SetValue(user, false, null);
                    }
                    object value2 = pi.GetValue(user, null);//用pi.GetValue获得值                
                    Console.WriteLine(name + ":" + value2);
                } 
                     
                       

        }

        private static void Method08()
        {

            OperationResult result = _container2.GetExportedValueOrDefault<ContainerIn>().UserContract.FindEntity("65128044");
            User user = (User)result.AppendData;
            Console.WriteLine(user.userpwd);
            Console.WriteLine();           
        }

        //添加主表跟从表的关系
        private static void Method09()
        {
            //User user = (User)_container.GetExportedValue<IUserSiteContract>().FindEntity("65128044").AppendData;
            User user=_container.GetExportedValue<IUserSiteContract>().Users().Single(r=>r.usercode=="65128044");
            List<UserGroup> userGroup = _container.GetExportedValue<IUserGroupSiteContract>().UserGroups().Where(u => u.usergroupcode.StartsWith("u")).ToList();
            foreach (var a in userGroup)
            {
                user.UserGroups.Add(a);     
            }
                

          
                       
            _container.GetExportedValue<DbContext>().SaveChanges();
            Console.WriteLine(user.UserGroups.Count);        
        }

        private static void Method10()
        {            
            User user = (User)_container.GetExportedValue<IUserSiteContract>().FindEntity("65128044").AppendData;
           // _container.GetExportedValue<DbContext>().Entry(user).Collection(r => r.UserGroups).Load();
            Console.WriteLine(user.UserGroups.First().usergroupcode);
        }

        //取数据库时间
        private static void Method11()
        {

            Console.WriteLine(_container.GetExportedValue<IUserSiteContract>().Users().Select(u => SqlFunctions.GetDate()).First().Value);
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