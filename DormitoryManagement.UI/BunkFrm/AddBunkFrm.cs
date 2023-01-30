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
    /// 添加床位窗体
    /// </summary>
    public partial class AddBunkFrm : Form
    {
        private BunkBll bll = new BunkBll();

        /// <summary>
        ///页面初始化加载窗体
        /// </summary>
        public AddBunkFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBunkFrm_Load(object sender, EventArgs e)
        {
            GetDormitory();
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
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBunkNo.Text.Trim()))
            {
                txtBunkNo.Focus();
                return;
            }
            Bunk bunk = new Bunk()
            {
                BunkNo = txtBunkNo.Text.Trim(),
                DormitoryId = (int)cboxDormitoryId.SelectedValue,
                IsEnable = rbtnQY.Checked ? true : false
            };
            var i = bll.AddBunk(bunk);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}