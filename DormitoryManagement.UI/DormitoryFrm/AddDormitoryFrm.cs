using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagement.BLL;
using DormitoryManagement.Model;

namespace DormitoryManagement.UI.DormitoryFrm
{
    public partial class AddDormitoryFrm : Form
    {
        private DormitoryBll bll = new DormitoryBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public AddDormitoryFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            var DormitoryNo = txtDormitoryNo.Text.Trim();

            //判断非空
            if (string.IsNullOrEmpty(DormitoryNo))
            {
                txtDormitoryNo.Focus();
                return;
            }

            //添加值
            Dormitory dormitory = new Dormitory()
            {
                DormitoryNo = DormitoryNo,
                DormitoryType = this.rbtnNan.Checked ? true : false,
                IsEnable = this.rbtnQY.Checked ? true : false,
            };
            var result = bll.AddDormitory(dormitory);
            if (result > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}