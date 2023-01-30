using DormitoryManagement.BLL;
using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement.UI.BasicInfo
{
    /// <summary>
    /// 添一级部门窗体
    /// </summary>
    public partial class DepartmentAdd : Form
    {
        private DepartmentBll bll = new DepartmentBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public DepartmentAdd()
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
            //部门名称
            var StairName = txtStairName.Text.Trim();

            //是否启用
            var IsEnable = rbtnYes.Checked ? true : false;

            //判断非空
            if (string.IsNullOrEmpty(StairName))
            {
                txtStairName.Focus();
                return;
            }
            //添加值
            Department department = new Department()
            {
                StairName = StairName,
                IsEnable = IsEnable
            };
            var result = bll.AddDepartment(department);
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
            txtStairName.Text = string.Empty;
            rbtnYes.Checked = false;
            rbtnNo.Checked = false;
        }
    }
}