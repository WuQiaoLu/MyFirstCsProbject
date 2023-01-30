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
using DormitoryManagement.BLL;
using NPOI.SS.Formula.Functions;

namespace DormitoryManagement.UI.StaffFrm
{
    /// <summary>
    /// 编辑员工窗体
    /// </summary>
    public partial class UpdStaffFrm : Form
    {
        private StaffBll bll = new StaffBll();

        private int staffid;

        /// <summary>
        /// 页面一加载初始化窗体
        /// </summary>
        public UpdStaffFrm(int id)
        {
            staffid = id;
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdStaffFrm_Load(object sender, EventArgs e)
        {
            BinDepartmentId();
            BinStationId();

            var staff = bll.GetStaffById(staffid);

            txtName.Text = staff.Name;

            if (staff.Sex)
                rbtnNan.Checked = true;
            else
                rbtnNv.Checked = true;
            if (staff.TypeId)
                rbtnGr.Checked = true;
            else
                rbtnYg.Checked = true;

            txtEmpNo.Text = staff.EmpNo;

            cboxDepartmentId.SelectedValue = staff.DepartmentId;
            cboxStationId.SelectedValue = staff.StationId;

            if (staff.IDCard)
                rbtnYes.Checked = true;
            else
                rbtnNo.Checked = true;

            txtMobile.Text = staff.Mobile;

            txtEmergencyName.Text = staff.EmergencyName;
            txtEmergencyMobile.Text = staff.EmergencyMobile;

            dpEntryTime.Value = staff.EntryTime;

            if (staff.IsEnable)
                rbtnShi.Checked = true;
            else
                rbtnN.Checked = true;
            if (staff.IsResidence == 1)
                rbtnFou.Checked = true;
            if (staff.IsResidence == 2)
                rbtnGSBL.Checked = true;
            if (staff.IsResidence == 3)
                rbtnZXBL.Checked = true;
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
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
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
            if (this.rbtnFou.Checked)
            {
                residence = Convert.ToInt32(rbtnFou.Tag);
            }

            if (this.rbtnGSBL.Checked)
            {
                residence = Convert.ToInt32(rbtnGSBL.Tag);
            }

            if (this.rbtnZXBL.Checked)
            {
                residence = Convert.ToInt32(rbtnZXBL.Tag);
            }

            Staff staff = new Staff()
            {
                Id = staffid,
                Name = this.txtName.Text.Trim(),
                Sex = this.rbtnNan.Checked ? true : false,
                TypeId = this.rbtnGr.Checked ? true : false,
                EmpNo = this.txtEmpNo.Text.Trim(),
                DepartmentId = (int)this.cboxDepartmentId.SelectedValue,
                StationId = (int)this.cboxStationId.SelectedValue,
                IDCard = this.rbtnYes.Checked ? true : false,
                Mobile = this.txtMobile.Text.Trim(),
                EmergencyName = this.txtEmergencyName.Text.Trim(),
                EmergencyMobile = this.txtEmergencyMobile.Text.Trim(),
                EntryTime = this.dpEntryTime.Value,
                IsEnable = rbtnShi.Checked ? true : false,
                IsResidence = residence
            };
            var i = bll.UpdStaff(staff);
            if (i > 0)
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}