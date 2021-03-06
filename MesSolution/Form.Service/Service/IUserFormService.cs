﻿using Component.Tools;
using Core.Models;
using Core.Service;
using Frm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frm.Models.FrmLogin;

namespace Frm.Service
{
    public interface IUserFormService:IUserService
    {
        /// <summary>
        ///     用户登录
        /// </summary>
        /// <param name="model">登录模型信息</param>
        /// <returns>业务操作结果</returns>
        OperationResult Login(LoginModel model);
    }
}
