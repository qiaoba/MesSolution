﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using Core.Db.Context;


namespace GMF.Demo.Core.Data.Initialize
{
    /// <summary>
    /// 数据库初始化操作类
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// 数据库初始化
        /// </summary>
        public static void Initialize( )
        {
            Database.SetInitializer(new SampleData());
            using (var db = new MesContext())
            {
                db.Database.Initialize(false);
            }
        }
    }
}
