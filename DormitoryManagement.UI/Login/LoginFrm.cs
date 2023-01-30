using System;
using System.Windows.Forms;
using DormitoryManagement.Model;
using DormitoryManagement.BLL;

namespace DormitoryManagement.UI
{
    /// <summary>
    /// 用户登录窗体
    /// </summary>
    public partial class LoginFrm : Form
    {
        private LoginBll bll = new LoginBll();

        /// <summary>
        /// 页面初始化加载控件
        /// </summary>
        public LoginFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string password = txtPassWord.Text.Trim();
            var userInfo = bll.Login(account, password);
            if (userInfo != null)
            {
                this.Hide();//隐藏登录页
                MainFrm mainFrm = new MainFrm();
                mainFrm.Show();//显示主页
            }
            else
            {
                MessageBox.Show("登录失败！", "提示");
            }
        }

        /// <summary>
        /// 重置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butReset_Click(object sender, EventArgs e)
        {
            txtAccount.Text = string.Empty;
            txtPassWord.Text = string.Empty;
        }
    }
}