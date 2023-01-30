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

namespace DormitoryManagement.UI.StaffStayOutFrm
{
    /// <summary>
    /// 编辑员工退宿功能页面
    /// </summary>
    public partial class UpdStaffStayOutFrm : Form
    {
        private StaffStayOutBll bll = new StaffStayOutBll();

        private int Id;

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public UpdStaffStayOutFrm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        /// <summary>
        /// 类似于文档就绪函数（边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdStaffStayOutFrm_Load(object sender, EventArgs e)
        {
            BinStaff();
            GetStaffStayOutById();
        }

        /// <summary>
        /// 绑定员工姓名下拉框
        /// </summary>
        public void BinStaff()
        {
            var staffList = bll.GetStaffList(0);
            staffList.Insert(0, new StaffStayOutDto { Id = 0, Name = "请选择" });
            cboxName.DisplayMember = "Name";
            cboxName.ValueMember = "Id";
            cboxName.DataSource = staffList;
        }

        /// <summary>
        /// 根据入住id反冲数据
        /// </summary>
        public void GetStaffStayOutById()
        {
            var list = bll.GetStaffStayOutById(Id);
            cboxName.Text = list.Name;
            lblEmpNo.Text = list.EmpNo;
            lblSex.Text = list.Sex == true ? "男" : "女";
            lblTypeId.Text = list.TypeId == true ? "员工" : "工人";
            lblDepartmentId.Text = list.StairName;
            lblStationId.Text = list.SecondName;
            lblMobile.Text = list.Mobile;
            lblEmergencyName.Text = list.EmergencyName;
            lblEmergencyMobile.Text = list.EmergencyMobile;
            cboxMoney.Text = list.Deduction.ToString();
            if (list.Treaty)
            {
                rbtnYes.Checked = true;
            }
            else
            {
                rbtnNo.Checked = true;
            }
            if (list.Access)
            {
                rbtnY.Checked = true;
            }
            else
            {
                rbtnN.Checked = true;
            }
            if (list.TowerParent)
            {
                rbtnOk.Checked = true;
            }
            else
            {
                rbtnNooK.Checked = true;
            }
            if (list.DormParent)
            {
                rbtnShi.Checked = true;
            }
            else
            {
                rbtnFou.Checked = true;
            }
            dpCheckInTime.Value = list.CheckInTime;
            dpStayOutTime.Value = list.StayOutTime;
        }

        /// <summary>
        /// 姓名下拉框选中点击事件
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
                var staff = bll.GetStaffList(id).FirstOrDefault();
                lblEmpNo.Text = staff.EmpNo;
                lblSex.Text = staff.Sex == true ? "男" : "女";
                lblTypeId.Text = staff.TypeId == true ? "员工" : "工人";
                lblDepartmentId.Text = staff.StairName;
                lblStationId.Text = staff.SecondName;
                lblMobile.Text = staff.Mobile;
                lblEmergencyName.Text = staff.EmergencyName;
                lblEmergencyMobile.Text = staff.EmergencyMobile;
                if (staff.Treaty)
                    rbtnYes.Checked = true;
                else
                    rbtnNo.Checked = true;

                if (staff.Access)
                    rbtnY.Checked = true;
                else
                    rbtnN.Checked = true;

                if (staff.TowerParent)
                    rbtnOk.Checked = true;
                else
                    rbtnNooK.Checked = true;

                if (staff.DormParent)
                    rbtnShi.Checked = true;
                else
                    rbtnFou.Checked = true;
                dpCheckInTime.Value = staff.CheckInTime;
            }
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboxName.SelectedValue) == 0)
            {
                cboxName.Focus();
                return;
            }

            StaffStayOutDto staffStayOutDto = new StaffStayOutDto();
            staffStayOutDto.Id = Id;
            staffStayOutDto.StaffId = Convert.ToInt32(cboxName.SelectedValue);
            staffStayOutDto.Deduction = Convert.ToInt32(cboxMoney.SelectedItem);
            staffStayOutDto.Treaty = rbtnYes.Checked ? true : false;
            staffStayOutDto.Access = rbtnY.Focused ? true : false;
            staffStayOutDto.TowerParent = rbtnOk.Checked ? true : false;
            staffStayOutDto.DormParent = rbtnShi.Checked ? true : false;
            staffStayOutDto.CheckInTime = dpCheckInTime.Value;
            staffStayOutDto.StayOutTime = dpStayOutTime.Value;
            var i = bll.UpdStaffStayOut(staffStayOutDto);
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