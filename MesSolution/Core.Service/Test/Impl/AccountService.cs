
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

using Component.Tools;
using Core.Db.Repositories;
using Core.Models;



namespace Core.Service.Impl
{
    /// <summary>
    ///     账户模块核心业务实现
    /// </summary>
    public abstract class AccountService : CoreServiceBase, IAccountService
    {
        #region 属性

        #region 受保护的属性

        /// <summary>
        /// 获取或设置 用户信息数据访问对象
        /// </summary>
        [Import]
        protected IMemberRepository MemberRepository { get; set; }

        /// <summary>
        /// 开发给展现层的接口
        /// </summary>
        public IQueryable<Member> Merbers()
        {
            return MemberRepository.Entities;
        }

        /// <summary>
        /// 获取或设置 登录记录信息数据访问对象
        /// </summary>
        [Import]
        protected ILoginLogRepository LoginLogRepository { get; set; }

        #endregion

        #endregion

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        public virtual OperationResult Login(LoginInfo loginInfo)
        {
            PublicHelper.CheckArgument(loginInfo, "loginInfo");
            Member member = MemberRepository.Entities.SingleOrDefault(m => m.UserName == loginInfo.Access || m.Email == loginInfo.Access);
            if (member == null)
            {
                return new OperationResult(OperationResultType.QueryNull, "指定账号的用户不存在。");
            }
            if (member.Password != loginInfo.Password)
            {
                return new OperationResult(OperationResultType.Warning, "登录密码不正确。");
            }
            LoginLog loginLog = new LoginLog { IpAddress = loginInfo.IpAddress, Member = member };
            LoginLogRepository.Insert(loginLog);            
            return new OperationResult(OperationResultType.Success, "登录成功。", member);
        }
    }
}