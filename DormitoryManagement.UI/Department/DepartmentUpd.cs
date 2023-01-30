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
    /// 编辑一级部门窗体
    /// </summary>
    public partial class DepartmentUpd : Form
    {
        private DepartmentBll bll = new DepartmentBll();

        //定义全局变量接收列表页传递的id
        private int departmentid;

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public DepartmentUpd(int id)
        {
            departmentid = id;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentUpd_Load(object sender, EventArgs e)
        {
            var department = bll.GetDepartmentById(departmentid);
            this.txtStairName.Text = department.StairName;
            if (department.IsEnable)
            {
                rbtnYes.Checked = true;
            }
            else
            {
                rbtnNo.Checked = true;
            }
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSave_Click(object sender, EventArgs e)
        {
            //一级部门名称
            var StairName = txtStairName.Text.Trim();
            //是否启用
            var IsEnable = rbtnYes.Checked ? true : false;
            //判断非空
            if (string.IsNullOrEmpty(StairName))
            {
                txtStairName.Focus();
                return;
            }
            //修改一级部门信息
            Department department = new Department()
            {
                StairName = StairName,
                IsEnable = IsEnable,
                Id = departmentid
            };
            var i = bll.UpdDepartment(department);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败");
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