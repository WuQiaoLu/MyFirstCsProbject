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
using DormitoryManagement.UI.StaffCheckInFrm;

namespace DormitoryManagement.UI.StaffStayOutFrm
{
    /// <summary>
    /// 员工退宿列表窗体
    /// </summary>
    public partial class StaffStayOutListFrm : Form
    {
        private StaffStayOutBll bll = new StaffStayOutBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public StaffStayOutListFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffStayOutListFrm_Load(object sender, EventArgs e)
        {
            GetStaffStayOutDto();
        }

        //定义分页变量
        private int pageIndex = 1;

        private int pageSize = 5;

        private int totalCount = 0;

        /// <summary>
        /// 查询数据库，绑定数据
        /// </summary>
        public void GetStaffStayOutDto()
        {
            //员工退宿信息
            PageResultDto<StaffStayOutDto> pageResult = bll.GetStaffStayOutDto(txtName.Text.Trim(), pageIndex, pageSize);

            //计算总页数
            totalCount = (int)Math.Ceiling(pageResult.ItemCount * 1.0 / pageSize);

            //分页语句
            labelFenYe.Text = $"共 {pageResult.ItemCount} 条数据，每页显示 {pageSize} 条，共 {totalCount} 页，当前第 {pageIndex} 页";

            //不让自动生成列
            this.StaffStayOutList.AutoGenerateColumns = false;

            //绑定信息
            this.StaffStayOutList.DataSource = pageResult.Items;
        }

        /// <summary>
        /// 需要设置单元格内容显示格式触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffCheckInList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "男";
                else
                    e.Value = "女";
            }

            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "员工";
                else
                    e.Value = "工人";
            }

            if (e.ColumnIndex == 7)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "是";
                else
                    e.Value = "否";
            }

            if (e.ColumnIndex == 8)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "是";
                else
                    e.Value = "否";
            }

            if (e.ColumnIndex == 12)
            {
                if (e.Value.ToString() == "True")
                    e.Value = "是";
                else
                    e.Value = "否";
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
            GetStaffStayOutDto();
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            AddStaffStayOutFrm addStaffStayOutFrm = new AddStaffStayOutFrm();
            if (addStaffStayOutFrm.ShowDialog() == DialogResult.OK)
            {
                GetStaffStayOutDto();
            }
        }

        /// <summary>
        /// 点击行内按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffStayOutList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = StaffStayOutList.Columns[e.ColumnIndex].Name;
            int id = (int)StaffStayOutList.Rows[e.RowIndex].Cells[0].Value;
            if (name == "编辑")
            {
                var updStaffStayOutFrm = new UpdStaffStayOutFrm(id);
                //关闭对话弹窗，如果设置对话状态为OK，则刷新父级页面列表数据
                if (updStaffStayOutFrm.ShowDialog() == DialogResult.OK)
                {
                    GetStaffStayOutDto();
                }
            }
            else if (name == "删除")
            {
                //友好提示
                MessageBox.Show("确认要删除吗！");

                var i = bll.DelStaffStayOut(id);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                    GetStaffStayOutDto();
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
        private void labSY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            GetStaffStayOutDto();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbSYY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                GetStaffStayOutDto();
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbXYY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < totalCount)
            {
                pageIndex++;
                GetStaffStayOutDto();
            }
        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labWY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = totalCount;
            GetStaffStayOutDto();
        }
    }
}