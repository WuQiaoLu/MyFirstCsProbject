using DormitoryManagement.DAL;
using DormitoryManagement.Model;

namespace DormitoryManagement.BLL
{
    /// <summary>
    /// 用户登录Bll
    /// </summary>
    public class LoginBll
    {
        private LoginDal dal = new LoginDal();

        /// <summary>
        /// 根据用户名、密码完成登录功能
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserInfo Login(string account, string password)
        {
            var userInfo = dal.Login(account, password);
            return userInfo;
        }
    }
}