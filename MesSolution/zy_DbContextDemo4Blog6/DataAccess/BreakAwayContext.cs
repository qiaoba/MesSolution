﻿using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Validation;

using System.Data;
using System.Linq;

//QQ群：33353329
//blog：oppoic.cnblogs.com

namespace DbContexts.DataAccess
{
    public class BreakAwayContext : DbContext
    {
        public BreakAwayContext()
            : base("name=BreakAwayContext")
        {
            ((IObjectContextAdapter)this).ObjectContext
            .ObjectMaterialized += (sender, args) =>
            {
                var entity = args.Entity as DbContexts.Model.IObjectWithState;
                if (entity != null)
                {
                    entity.State = DbContexts.Model.State.Unchanged;
                }
            };

            //Configuration.ValidateOnSaveEnabled = false;  //调用SaveChanges方法的时候不验证实体
        }

        //标识
        public bool LogChangesDuringSave { get; set; }

        /// <summary>
        /// 记录帮助类
        /// </summary>
        private void PrintPropertyValues(DbPropertyValues values, IEnumerable<string> propertiesToPrint, int indent = 1)
        {
            foreach (var propertyName in propertiesToPrint)
            {
                var value = values[propertyName];
                if (value is DbPropertyValues)
                {
                    Console.WriteLine("{0}- Complex Property: {1}", string.Empty.PadLeft(indent), propertyName);
                    var complexPropertyValues = (DbPropertyValues)value;
                    PrintPropertyValues(complexPropertyValues, complexPropertyValues.PropertyNames, indent + 1);
                }
                else
                {
                    Console.WriteLine("{0}- {1}: {2}", string.Empty.PadLeft(indent), propertyName, values[propertyName]);
                }
            }
        }
        private IEnumerable<string> GetKeyPropertyNames(object entity)
        {
            var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            return objectContext.ObjectStateManager.GetObjectStateEntry(entity).EntityKey.EntityKeyValues.Select(k => k.Key);
        }

        /// <summary>
        /// 重写SaveChanges方法
        /// </summary>
        public override int SaveChanges()
        {
            if (LogChangesDuringSave)  //根据表示判断用重写的SaveChanges方法，还是普通的上下文SaveChanges方法
            {
                var entries = from e in this.ChangeTracker.Entries()
                              where e.State != EntityState.Unchanged
                              select e;   //过滤所有修改了的实体，包括：增加 / 修改 / 删除
                foreach (var entry in entries)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            Console.WriteLine("Adding a {0}", entry.Entity.GetType());
                            PrintPropertyValues(entry.CurrentValues, entry.CurrentValues.PropertyNames);
                            break;
                        case EntityState.Deleted:
                            Console.WriteLine("Deleting a {0}", entry.Entity.GetType());
                            PrintPropertyValues(entry.OriginalValues, GetKeyPropertyNames(entry.Entity));
                            break;
                        case EntityState.Modified:
                            Console.WriteLine("Modifying a {0}", entry.Entity.GetType());
                            var modifiedPropertyNames = from n in entry.CurrentValues.PropertyNames
                                                        where entry.Property(n).IsModified
                                                        select n;
                            PrintPropertyValues(entry.CurrentValues, GetKeyPropertyNames(entry.Entity).Concat(modifiedPropertyNames));
                            break;
                    }
                }
            }
            return base.SaveChanges();  //返回普通的上下文SaveChanges方法
        }

        /// <summary>
        /// 重写ValidateEntity方法实现验证（ValidateEntity验证会在定制的验证规则通过后执行）
        /// </summary>
        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            //var result = new DbEntityValidationResult(entityEntry, new List<DbValidationError>());
            //var reservation = entityEntry.Entity as DbContexts.Model.Reservation;
            //if (reservation != null)
            //{
            //    if (entityEntry.State == EntityState.Added && reservation.Payments.Count == 0)
            //    {
            //        result.ValidationErrors.Add(new DbValidationError("Reservation", "New reservation must have a payment."));
            //    }
            //}
            //ValidateReservation(result);
            //if (!result.IsValid)
            //{
            //    return result;
            //}
            //return base.ValidateEntity(entityEntry, items);  //调用基类的验证方法

            var result = base.ValidateEntity(entityEntry, items);  //先走上下文验证
            if (result.IsValid)
            {
                ValidateLodging(result);  //上下文验证通过再验证自定义验证
            }
            return result;

            //两者同时验证：
            //var result = base.ValidateEntity(entityEntry, items);
            //ValidateLodging(result);
            //return result;
        }

        /// <summary>
        /// 多个验证规则
        /// </summary>
        private void ValidateReservation(DbEntityValidationResult result)
        {
            var reservation = result.Entry.Entity as DbContexts.Model.Reservation;
            if (reservation != null)
            {
                if (result.Entry.State == EntityState.Added && reservation.Payments.Count == 0)
                {
                    result.ValidationErrors.Add(new DbValidationError("Reservation", "New reservation must have a payment."));
                }
            }
        }

        /// <summary>
        /// 自定义验证：每一个目的地类Destination下不能有同名的住宿类Lodging
        /// </summary>
        /// <param name="result"></param>
        private void ValidateLodging(DbEntityValidationResult result)
        {
            var lodging = result.Entry.Entity as DbContexts.Model.Lodging;
            if (lodging != null && lodging.DestinationId != 0)
            {
                if (Lodgings.Any(l => l.Name == lodging.Name && l.DestinationId == lodging.DestinationId))
                {
                    result.ValidationErrors.Add(new DbValidationError("Lodging", "There is already a lodging named " + lodging.Name + " at this destination."));
                }
            }
        }

        //以下是数据库上下文对象，以后对数据库的访问就用下面对象
        public DbSet<DbContexts.Model.Destination> Destinations { get; set; }
        public DbSet<DbContexts.Model.Lodging> Lodgings { get; set; }
        public DbSet<DbContexts.Model.Trip> Trip { get; set; }
        public DbSet<DbContexts.Model.Person> People { get; set; }
        public DbSet<DbContexts.Model.Reservation> Reservations { get; set; }
        public DbSet<DbContexts.Model.Payment> Payments { get; set; }
        public DbSet<DbContexts.Model.Activity> Activities { get; set; }


        //用Fluent api必须重写OnModelCreating方法
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //本例使用的Data Annotation配置的数据库，故这里一行也没有

        }
    }
}
