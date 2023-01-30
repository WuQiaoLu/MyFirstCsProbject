using DormitoryManagement.Common;
using DormitoryManagement.Model;
using System;
using System.Linq;

namespace DormitoryManagement.DAL
{
    /// <summary>
    /// 用户登录Dal
    /// </summary>
    public class LoginDal
    {
        /// <summary>
        /// 根据用户名、密码完成登录功能
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserInfo Login(string account, string password)
        {
            try
            {
                string cmdString = $"select * from UserInfo where Account='{account}' and PassWord='{password}'";
                var userinfo = DapperHelper.GetList<UserInfo>(cmdString).FirstOrDefault();
                return userinfo;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}