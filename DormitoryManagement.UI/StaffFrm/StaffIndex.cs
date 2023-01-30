using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DormitoryManagement.BLL;
using DormitoryManagement.Model;

namespace DormitoryManagement.UI.StaffFrm
{
    /// <summary>
    /// 员工详情页面
    /// </summary>
    public partial class StaffIndex : Form
    {
        private int staffId;

        private StaffBll bll = new StaffBll();

        /// <summary>
        /// 页面一加载初始化窗体
        /// </summary>
        /// <param name="id"></param>
        public StaffIndex(int id)
        {
            staffId = id;
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffIndex_Load(object sender, EventArgs e)
        {
            var staff = bll.GetStaffById(staffId);

            lblName.Text = staff.Name;
            lblEmpNo.Text = staff.EmpNo;
            lblSex.Text = staff.Sex ? "男" : "女";
            lblTypeId.Text = staff.TypeId ? "员工" : "工人";
            lblDepartmentId.Text = staff.StairName;
            lblStationId.Text = staff.SecondName;
            lblMobile.Text = staff.Mobile;
            lblIDCard.Text = staff.IDCard ? "是" : "否";
            lblEmergencyName.Text = staff.EmergencyName;
            lblEmergencyMobile.Text = staff.EmergencyMobile;
            if (staff.IsResidence == 1)
            {
                lblIsResidence.Text = "否";
            }
            if (staff.IsResidence == 2)
            {
                lblIsResidence.Text = "公司办理";
            }
            if (staff.IsResidence == 3)
            {
                lblIsResidence.Text = "自行办理";
            }
            lblIsEnable.Text = staff.IsEnable ? "是" : "否";
            lblEntryTime.Text = staff.EntryTime.ToString();
        }

        /// <summary>
        /// 返回按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}