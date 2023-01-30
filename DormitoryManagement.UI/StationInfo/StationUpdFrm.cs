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

namespace DormitoryManagement.UI.StationInfo
{
    /// <summary>
    /// 编辑二级部门页面
    /// </summary>
    public partial class StationUpdFrm : Form
    {
        private StationBll bll = new StationBll();

        //定义全局变量接收列表页传递的id
        private int stationid;

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public StationUpdFrm(int id)
        {
            stationid = id;
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationUpdFrm_Load(object sender, EventArgs e)
        {
            BinParentId();
            var station = bll.GetStationById(stationid);
            this.txtSecondName.Text = station.SecondName;
            CboxParentId.SelectedValue = station.ParentId;
            if (station.IsEnable)
            {
                rbtnYes.Checked = true;
            }
            else
            {
                rbtnNo.Checked = true;
            }
        }

        /// <summary>
        /// 绑定下拉框
        /// </summary>
        private void BinParentId()
        {
            var list = bll.BinParentId();
            CboxParentId.DisplayMember = "StairName";
            CboxParentId.ValueMember = "Id";
            CboxParentId.DataSource = list;
        }

        /// <summary>
        /// 保存按钮点击时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSave_Click(object sender, EventArgs e)
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
                Id = stationid,
                SecondName = this.txtSecondName.Text.Trim(),
                ParentId = (int)this.CboxParentId.SelectedValue,
                IsEnable = this.rbtnYes.Checked ? true : false
            };
            var i = bll.UpdStation(station);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败！");
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