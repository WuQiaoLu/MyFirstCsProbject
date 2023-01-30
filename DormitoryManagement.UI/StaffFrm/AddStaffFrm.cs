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

namespace DormitoryManagement.UI.StaffFrm
{
    /// <summary>
    /// 添加员工信息窗体
    /// </summary>
    public partial class AddStaffFrm : Form
    {
        private StaffBll bll = new StaffBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public AddStaffFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStaffFrm_Load(object sender, EventArgs e)
        {
            BinDepartmentId();
            BinStationId();
        }

        /// <summary>
        /// 绑定一级部门下拉框
        /// </summary>
        public void BinDepartmentId()
        {
            var list = bll.BinDepartmentId();
            list.Insert(0, new Department() { Id = 0, StairName = "请选择" });
            cboxDepartmentId.DisplayMember = "StairName";
            cboxDepartmentId.ValueMember = "Id";
            cboxDepartmentId.DataSource = list;
        }

        /// <summary>
        /// 绑定二级部门下拉框
        /// </summary>
        public void BinStationId()
        {
            var list = bll.BinStationId();
            list.Insert(0, new Station() { Id = 0, SecondName = "请选择" });
            cboxStationId.DisplayMember = "SecondName";
            cboxStationId.ValueMember = "Id";
            cboxStationId.DataSource = list;
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEmpNo.Text.Trim()))
            {
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEmergencyMobile.Text.Trim()))
            {
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEmergencyName.Text.Trim()))
            {
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMobile.Text.Trim()))
            {
                txtName.Focus();
                return;
            }
            int residence = 0;
            if (rdoStaffIsResidence1.Checked)
                residence = 1;
            if (rdoStaffIsResidence2.Checked)
                residence = 2;
            if (rdoStaffIsResidence3.Checked)
                residence = 3;

            Staff staff = new Staff()
            {
                Name = txtName.Text.Trim(),
                Sex = rbtnNan.Checked ? true : false,
                TypeId = rbtnGr.Checked ? true : false,
                EmpNo = txtEmpNo.Text.Trim(),
                DepartmentId = (int)cboxDepartmentId.SelectedValue,
                StationId = (int)cboxStationId.SelectedValue,
                IDCard = rbtnYes.Checked ? true : false,
                Mobile = txtMobile.Text.Trim(),
                EmergencyName = txtEmergencyName.Text.Trim(),
                EmergencyMobile = txtEmergencyMobile.Text.Trim(),
                EntryTime = dpEntryTime.Value,
                IsEnable = rbtnShi.Checked ? true : false,
                IsResidence = residence
            };
            var i = bll.AddStaff(staff);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}