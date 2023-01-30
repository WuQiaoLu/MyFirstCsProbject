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
    /// <summary>
    /// 编辑宿舍窗体
    /// </summary>
    public partial class UpdDormitoryFrm : Form
    {
        private DormitoryBll bll = new DormitoryBll();

        //定义全局变量接收列表页传递的id
        private int Id;

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public UpdDormitoryFrm(int id)
        {
            this.Id = id;
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdDormitoryFrm_Load(object sender, EventArgs e)
        {
            GetDormitoryById();
        }

        /// <summary>
        /// 从数据库中获取数据
        /// </summary>
        public void GetDormitoryById()
        {
            var data = bll.GetDormitoryById(Id);
            this.txtDormitoryNo.Text = data.DormitoryNo;
            if (data.DormitoryType)
            {
                rbtnNan.Checked = true;
            }
            else
            {
                rbtnNv.Checked = true;
            }
            if (data.IsEnable)
            {
                rbtnQY.Checked = true;
            }
            else
            {
                rbtnJY.Checked = true;
            }
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSave_Click(object sender, EventArgs e)
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
                Id= Id,
                DormitoryNo = DormitoryNo,
                DormitoryType=rbtnNan.Checked?true:false,
                IsEnable = rbtnQY.Checked ? true : false,
            };
            var result = bll.UpdDormitory(dormitory);
            if (result > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("编辑失败");
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