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
using DormitoryManagement.Common;

namespace DormitoryManagement.UI.StaffFrm
{
    /// <summary>
    /// 员工列表窗体
    /// </summary>
    public partial class StaffListFrm : Form
    {
        private StaffBll bll = new StaffBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public StaffListFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffListFrm_Load(object sender, EventArgs e)
        {
            GetStaff();
        }

        //定义分页变量
        private int pageIndex = 1;

        private int pageSize = 5;

        private int totalCount = 0;

        /// <summary>
        /// 查询数据库，绑定数据
        /// </summary>
        public void GetStaff()
        {
            //员工信息
            PageResultDto<StaffDto> pageResult = bll.GetStaff(txtName.Text.Trim(), pageIndex, pageSize);

            //计算总页数
            totalCount = (int)Math.Ceiling(pageResult.ItemCount * 1.0 / pageSize);

            //分页语句
            labelFenYe.Text = $"共 {pageResult.ItemCount} 条数据，每页显示 {pageSize} 条，共 {totalCount} 页，当前第 {pageIndex} 页";

            //不让自动生成列
            this.StaffList.AutoGenerateColumns = false;

            //绑定信息
            this.StaffList.DataSource = pageResult.Items;
        }

        /// <summary>
        /// 需要设置单元格内容显示格式触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "男";
                }
                else
                {
                    e.Value = "女";
                }
            }

            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "员工";
                else
                    e.Value = "工人";
            }

            if (e.ColumnIndex == 8)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "启用";
                }
                else
                {
                    e.Value = "禁用";
                }
            }
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSelect_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            GetStaff();
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            AddStaffFrm addStaffFrm = new AddStaffFrm();
            if (addStaffFrm.ShowDialog() == DialogResult.OK)
            {
                GetStaff();
            }
        }

        /// <summary>
        /// 点击行内按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = StaffList.Columns[e.ColumnIndex].Name;
            int id = (int)StaffList.Rows[e.RowIndex].Cells[0].Value;
            if (name == "详情")
            {
                var staffIndex = new StaffIndex(id);
                //关闭对话弹窗，如果设置对话状态为OK，则刷新父级页面列表数据
                if (staffIndex.ShowDialog() == DialogResult.OK)
                {
                    GetStaff();
                }
            }
            else if (name == "编辑")
            {
                var updstaff = new UpdStaffFrm(id);
                //关闭对话弹窗，如果设置对话状态为OK，则刷新父级页面列表数据
                if (updstaff.ShowDialog() == DialogResult.OK)
                {
                    GetStaff();
                }
            }
            else if (name == "删除")
            {
                //友好提示
                MessageBox.Show("确认要删除吗！");

                var i = bll.DelStaff(id);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                    GetStaff();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            GetStaff();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                GetStaff();
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < totalCount)
            {
                pageIndex++;
                GetStaff();
            }
        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = totalCount;
            GetStaff();
        }
    }
}