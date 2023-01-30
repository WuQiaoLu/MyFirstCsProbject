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
using DormitoryManagement.BLL.BasicInfo;
using DormitoryManagement.Model;

namespace DormitoryManagement.UI.BunkFrm
{
    /// <summary>
    /// 编辑床位窗体
    /// </summary>
    public partial class UpdBunkFrm : Form
    {
        private int Id;

        //定义全局变量接收列表页传递的id
        private BunkBll bll = new BunkBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        /// <param name="id"></param>
        public UpdBunkFrm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        /// <summary>
        /// 类似于文档就绪函数（边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdBunkFrm_Load(object sender, EventArgs e)
        {
            GetDormitory();
            var list = bll.GetBunkByid(Id);
            this.txtBunkNo.Text = list.BunkNo;
            this.cboxDormitoryId.SelectedValue = list.DormitoryId;
            if (list.IsEnable)
            {
                rbtnQY.Checked = true;
            }
            else
            {
                rbtnJY.Checked = true;
            }
        }

        /// <summary>
        /// 绑定下拉框
        /// </summary>
        public void GetDormitory()
        {
            var list = bll.GetDormitory();
            list.Insert(0, new Model.Dormitory() { Id = 0, DormitoryNo = "请选择" });
            cboxDormitoryId.DisplayMember = "DormitoryNo";
            cboxDormitoryId.ValueMember = "Id";
            cboxDormitoryId.DataSource = list;
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBunkNo.Text.Trim()))
            {
                txtBunkNo.Focus();
                return;
            }
            Bunk bunk = new Bunk()
            {
                Id = Id,
                BunkNo = txtBunkNo.Text.Trim(),
                DormitoryId = (int)cboxDormitoryId.SelectedValue,
                IsEnable = rbtnQY.Checked ? true : false
            };
            var i = bll.UpdBunk(bunk);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("编辑失败！");
            }
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCancel_Click(object sender, EventArgs e)
        {
        }
    }
}