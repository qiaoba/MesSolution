﻿/*************************************************************************************
    * CLR版本：       4.0.30319.18444
    * 类 名 称：       SampleData2
    * 机器名称：       PC201405051109
    * 命名空间：       Core.Db.Initialize
    * 文 件 名：       SampleData2
    * 创建时间：       2014/10/17 20:13:35
    * 作    者：          梁 贵
    * 说   明：。。。。。
    * 修改时间：		
    * 修 改 人：		
   *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using Core.Db.Context;
using Core.Models;
using Component.Tools;
using System.Reflection;
using System.Collections.ObjectModel;
using Core.Db.Initialize;


namespace GMF.Demo.Core.Data.Initialize
{
    /// <summary>
    /// 数据库初始化策略
    /// </summary>
    public class DropCreateDatabaseIfModel : DropCreateDatabaseAlways<MesContext> 
    {
        protected override void Seed(MesContext context)
        {
            context.Configuration.AutoDetectChangesEnabled = false;
            int num = 11;
            List<User> users = new List<User>
            
            {
                new User{usercode = "65128041",userpwd = "123",AddDate = DateTime.Now,eattribute1 = "123",IsDeleted = false,mdate = DateTime.Now,muser = "123",userdepart = "123",useremail = "123",username = "lg",userstat = "123",usertel = "123"},
                new User{usercode = "65128042",userpwd = "123",AddDate = DateTime.Now,eattribute1 = "123",IsDeleted = false,mdate = DateTime.Now,muser = "123",userdepart = "123",useremail = "123",username = "lg",userstat = "123",usertel = "123"},
                new User{usercode = "65128043",userpwd = "123",AddDate = DateTime.Now,eattribute1 = "123",IsDeleted = false,mdate = DateTime.Now,muser = "123",userdepart = "123",useremail = "123",username = "lg",userstat = "123",usertel = "123"},
                new User{usercode = "65128044",userpwd = "123",AddDate = DateTime.Now,eattribute1 = "123",IsDeleted = false,mdate = DateTime.Now,muser = "123",userdepart = "123",useremail = "123",username = "lg",userstat = "123",usertel = "123"},
                new User{usercode = "65128045",userpwd = "123",AddDate = DateTime.Now,eattribute1 = "123",IsDeleted = false,mdate = DateTime.Now,muser = "123",userdepart = "123",useremail = "123",username = "lg",userstat = "123",usertel = "123"}
            };
            DbSet<User> userSet = context.Set<User>();
            users.ForEach(u => userSet.Add(u));

            Initialize<User>.Infial(num).ForEach(u => context.Set<User>().Add(u));
            Initialize<UserGroup>.Infial(num).ForEach(u => context.Set<UserGroup>().Add(u));
            Initialize<Res>.Infial(num).ForEach(u => context.Set<Res>().Add(u));
            Initialize<Mdl>.Infial(num).ForEach(u => context.Set<Mdl>().Add(u));
            Initialize<Mo>.Infial(num).ForEach(u => context.Set<Mo>().Add(u));
            Initialize<Item>.Infial(num).ForEach(u => context.Set<Item>().Add(u));
            Initialize<Op>.Infial(num).ForEach(u => context.Set<Op>().Add(u));
            Initialize<Route>.Infial(num).ForEach(u => context.Set<Route>().Add(u));
            Initialize<Item2SnCheck>.Infial(num).ForEach(u => context.Set<Item2SnCheck>().Add(u));
            Initialize<MoRcard>.Infial(num).ForEach(u => context.Set<MoRcard>().Add(u));
            Initialize<Simulation>.Infial(num).ForEach(u => context.Set<Simulation>().Add(u));
            Initialize<SimulationReport>.Infial(num).ForEach(u => context.Set<SimulationReport>().Add(u));
            Initialize<Model>.Infial(num).ForEach(u => context.Set<Model>().Add(u));
            Initialize<Route2Op>.Infial(num).ForEach(u => context.Set<Route2Op>().Add(u));

            Initialize<Duty>.Infial(num).ForEach(u => context.Set<Duty>().Add(u));
            Initialize<Ec>.Infial(num).ForEach(u => context.Set<Ec>().Add(u));
            Initialize<Ecg>.Infial(num).ForEach(u => context.Set<Ecg>().Add(u));
            Initialize<Ecs>.Infial(num).ForEach(u => context.Set<Ecs>().Add(u));
            Initialize<Ecsg>.Infial(num).ForEach(u => context.Set<Ecsg>().Add(u));
            Initialize<Solution>.Infial(num).ForEach(u => context.Set<Solution>().Add(u));
            
            context.Configuration.AutoDetectChangesEnabled = true;
            context.SaveChanges();
            Initialize<User>.InfialData();          
        }
      
     



    }
}