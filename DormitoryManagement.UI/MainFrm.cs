using DormitoryManagement.UI.BasicInfo;
using DormitoryManagement.UI.BunkFrm;
using DormitoryManagement.UI.DormitoryDetailDTOFrm;
using DormitoryManagement.UI.DormitoryFrm;
using DormitoryManagement.UI.StaffCheckInFrm;
using DormitoryManagement.UI.StaffFrm;
using DormitoryManagement.UI.StaffStaffStayOutFrm;
using DormitoryManagement.UI.StaffStayOutFrm;
using DormitoryManagement.UI.StationInfo;
using DormitoryManagement.UI.StayoutFrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement.UI
{
    /// <summary>
    /// 主页面窗体
    /// </summary>
    public partial class MainFrm : Form
    {
        /// <summary>
        /// 页面初始化加载控件
        /// </summary>
        public MainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 激活已经打开的子窗体
        /// </summary>
        /// <param name="formChild"></param>
        private void OpenChildForm(Form formChild)
        {
            var isOpen = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formChild.Name)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    formChild.Dispose();
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                formChild.MdiParent = this;
                formChild.WindowState = FormWindowState.Maximized;
                formChild.Show();
            }
        }

        /// <summary>
        /// 一级部门维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Department_Click(object sender, EventArgs e)
        {
            DepartmentListFrm department = new DepartmentListFrm();
            department.Name = "DepartmentListFrm";
            OpenChildForm(department);
        }

        /// <summary>
        /// 二级部门维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Station_Click(object sender, EventArgs e)
        {
            StationListFrm stationListFrm = new StationListFrm();
            stationListFrm.Name = "StationListFrm";
            OpenChildForm(stationListFrm);
        }

        /// <summary>
        /// 员工维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Staff_Click(object sender, EventArgs e)
        {
            StaffListFrm staffListFrm = new StaffListFrm();
            staffListFrm.Name = "StaffListFrm";
            OpenChildForm(staffListFrm);
        }

        /// <summary>
        /// 宿舍维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dormitory_Click(object sender, EventArgs e)
        {
            DormitoryListFrm dormitoryListFrm = new DormitoryListFrm();
            dormitoryListFrm.Name = "DormitoryListFrm";
            OpenChildForm(dormitoryListFrm);
        }

        /// <summary>
        /// 床位维护点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bunk_Click(object sender, EventArgs e)
        {
            BunkListFrm bunkListFrm = new BunkListFrm();
            bunkListFrm.Name = "BunkListFrm";
            OpenChildForm(bunkListFrm);
        }

        /// <summary>
        /// 入住管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffCheckIn_Click(object sender, EventArgs e)
        {
            StaffCheckInListFrm staffCheckInListFrm = new StaffCheckInListFrm();
            staffCheckInListFrm.Name = "StaffCheckInListFrm";
            OpenChildForm(staffCheckInListFrm);
        }

        /// <summary>
        /// 住宿扣款点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffStaffStayOut_Click(object sender, EventArgs e)
        {
            StaffStaffStayOutListFrm staffStaffStayOutListFrm = new StaffStaffStayOutListFrm();
            staffStaffStayOutListFrm.Name = "StaffStaffStayOutListFrm";
            OpenChildForm(staffStaffStayOutListFrm);
        }

        /// <summary>
        /// 员工退宿管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffStayOut_Click(object sender, EventArgs e)
        {
            StaffStayOutListFrm staffStayOutListFrm = new StaffStayOutListFrm();
            staffStayOutListFrm.Name = "StaffStayOutListFrm";
            OpenChildForm(staffStayOutListFrm);
        }

        /// <summary>
        /// 退宿扣款点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stayout_Click(object sender, EventArgs e)
        {
            StayoutListFrm stayoutListFrm = new StayoutListFrm();
            stayoutListFrm.Name = "StayoutListFrm";
            OpenChildForm(stayoutListFrm);
        }

        /// <summary>
        /// 住宿统计点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitoryDetailDTO_Click(object sender, EventArgs e)
        {
            DormitoryDetailDTOListFrm dormitoryDetailDTOListFrm = new DormitoryDetailDTOListFrm();
            dormitoryDetailDTOListFrm.Name = "DormitoryDetailDTOListFrm";
            OpenChildForm(dormitoryDetailDTOListFrm);
        }

        /// <summary>
        /// 汇总统计点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitorystatisticsFrm_Click(object sender, EventArgs e)
        {
            DormitorystatisticsFrm toolStripMenuItem = new DormitorystatisticsFrm();
            toolStripMenuItem.Name = "DormitorystatisticsFrm";
            OpenChildForm(toolStripMenuItem);
        }

        /// <summary>
        /// 点击关闭按钮时程序停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}