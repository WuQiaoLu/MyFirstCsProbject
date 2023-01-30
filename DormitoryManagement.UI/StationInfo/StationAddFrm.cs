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
using NPOI.POIFS.Properties;

namespace DormitoryManagement.UI.StationInfo
{
    /// <summary>
    /// 二级部门添加窗体
    /// </summary>
    public partial class StationAddFrm : Form
    {
        private StationBll bll = new StationBll();

        /// <summary>
        /// 页面一加载初始化窗体
        /// </summary>
        public StationAddFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationAddFrm_Load(object sender, EventArgs e)
        {
            BinParentId();
        }

        /// <summary>
        /// 绑定下拉框
        /// </summary>
        public void BinParentId()
        {
            var list = bll.BinParentId();
            CboxParentId.DisplayMember = "StairName";
            CboxParentId.ValueMember = "Id";
            CboxParentId.DataSource = list;
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            //判断非空
            if (string.IsNullOrEmpty(txtSecondName.Text.Trim()))
            {
                txtSecondName.Focus();
                return;
            }

            //添加值
            Station station = new Station()
            {
                SecondName = this.txtSecondName.Text.Trim(),
                ParentId = (int)this.CboxParentId.SelectedValue,
                IsEnable = this.rbtnYes.Checked ? true : false
            };
            var i = bll.AddStation(station);
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
        /// 重置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butReset_Click(object sender, EventArgs e)
        {
            txtSecondName.Text = string.Empty;
            CboxParentId.SelectedValue = string.Empty;
            rbtnYes.Checked = false;
            rbtnNo.Checked = false;
        }
    }
}