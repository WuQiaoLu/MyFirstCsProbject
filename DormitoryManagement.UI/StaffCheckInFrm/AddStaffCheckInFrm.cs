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
using NPOI.OpenXmlFormats.Dml.Diagram;
using NPOI.SS.Formula.Functions;

namespace DormitoryManagement.UI.StaffCheckInFrm
{
    /// <summary>
    /// 添加员工入住窗体
    /// </summary>
    public partial class AddStaffCheckInFrm : Form
    {
        private StaffCheckInBll bll = new StaffCheckInBll();

        /// <summary>
        ///页面初始化加载窗体
        /// </summary>
        public AddStaffCheckInFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStaffCheckInFrm_Load(object sender, EventArgs e)
        {
            BinStaff();
            GetDormitory();
        }

        /// <summary>
        /// 绑定员工姓名下拉框
        /// </summary>
        public void BinStaff()
        {
            var staffList = bll.GetStaffById(0);
            staffList.Insert(0, new StaffDto { Id = 0, Name = "请选择" });
            cboxName.DisplayMember = "Name";
            cboxName.ValueMember = "Id";
            cboxName.DataSource = staffList;
        }

        /// <summary>
        /// 下拉框点击选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEmpNo.Text = string.Empty;
            lblSex.Text = string.Empty;
            lblTypeId.Text = string.Empty;
            lblDepartmentId.Text = string.Empty;
            lblStationId.Text = string.Empty;
            lblMobile.Text = string.Empty;
            lblEmergencyName.Text = string.Empty;
            lblEmergencyMobile.Text = string.Empty;
            int id = (int)cboxName.SelectedValue;
            if (id > 0)
            {
                var staff = bll.GetStaffById(id).FirstOrDefault();
                lblEmpNo.Text = staff.EmpNo;
                lblSex.Text = staff.Sex == true ? "男" : "女";
                lblTypeId.Text = staff.TypeId == true ? "员工" : "工人";
                lblDepartmentId.Text = staff.StairName;
                lblStationId.Text = staff.SecondName;
                lblMobile.Text = staff.Mobile;
                lblEmergencyName.Text = staff.EmergencyName;
                lblEmergencyMobile.Text = staff.EmergencyMobile;
            }
        }

        /// <summary>
        /// 绑定宿舍表
        /// </summary>
        public void GetDormitory()
        {
            var list = bll.GetDormitory();
            list.Insert(0, new Dormitory { Id = 0, DormitoryNo = "请选择" });
            cboxDormitoryId.DisplayMember = "DormitoryNo";
            cboxDormitoryId.ValueMember = "Id";
            cboxDormitoryId.DataSource = list;
        }

        /// <summary>
        /// 绑定床位表（选中宿舍）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxDormitoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxBunkId.Items.Count > 0)
            {
                cboxBunkId.DataSource = null;
                cboxBunkId.Items.Clear();
            }
            int id = (int)cboxDormitoryId.SelectedValue;
            var list = bll.GetBunk(id);
            cboxBunkId.DisplayMember = "BunkNo";
            cboxBunkId.ValueMember = "Id";
            cboxBunkId.DataSource = list;
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboxName.SelectedValue) == 0)
            {
                cboxName.Focus();
                return;
            }
            if (Convert.ToInt32(cboxDormitoryId.SelectedValue) == 0)
            {
                cboxDormitoryId.Focus();
                return;
            }
            if (Convert.ToInt32(cboxBunkId.SelectedValue) == 0)
            {
                cboxBunkId.Focus();
                return;
            }
            StaffCheckIn staffCheckIn = new StaffCheckIn();
            staffCheckIn.StaffId = Convert.ToInt32(cboxName.SelectedValue);
            staffCheckIn.Money = Convert.ToInt32(cboxMoney.SelectedItem);
            staffCheckIn.Treaty = rbtnYes.Checked ? true : false;
            staffCheckIn.Access = rbtnY.Checked ? true : false;
            staffCheckIn.DormitoryId = Convert.ToInt32(cboxDormitoryId.SelectedValue);
            staffCheckIn.BunkId = Convert.ToInt32(cboxBunkId.SelectedValue);
            staffCheckIn.TowerParent = rbtnOk.Checked ? true : false;
            staffCheckIn.DormParent = rbtnShi.Checked ? true : false;
            staffCheckIn.CheckInTime = dpCheckInTime.Value;
            staffCheckIn.IsEnable = rbtnQY.Checked ? true : false;
            var i = bll.AddStaffCheckIn(staffCheckIn);
            if (i > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCercal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}