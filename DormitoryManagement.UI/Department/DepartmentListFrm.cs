using DormitoryManagement.BLL;
using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DormitoryManagement.UI.BasicInfo
{
    /// <summary>
    /// 一级部门维护窗体
    /// </summary>
    public partial class DepartmentListFrm : Form
    {
        private DepartmentBll bll = new DepartmentBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public DepartmentListFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentFrm_Load(object sender, EventArgs e)
        {
            GetDepartmentList();
        }

        /// <summary>
        /// 数据库中查询数据绑定
        /// </summary>
        private void GetDepartmentList()
        {
            //一级部门信息
            List<Department> departments = bll.GetDepartment();

            //不让自动生成列
            this.DepartmentList.AutoGenerateColumns = false;

            //绑定信息
            this.DepartmentList.DataSource = departments;
        }

        /// <summary>
        /// 需要设置单元格内容显示格式触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "是";
                }
                else
                {
                    e.Value = "否";
                }
            }
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            DepartmentAdd departmentAdd = new DepartmentAdd();

            if (departmentAdd.ShowDialog() == DialogResult.OK)
            {
                GetDepartmentList();
            }
        }

        /// <summary>
        /// 点击列中按钮时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = DepartmentList.Columns[e.ColumnIndex].Name;
            int id = (int)DepartmentList.Rows[e.RowIndex].Cells[0].Value;
            if (name == "编辑")
            {
                var departmentUpd = new DepartmentUpd(id);
                //关闭对话弹窗，如果设置对话状态为OK，则刷新父级页面列表数据
                if (departmentUpd.ShowDialog() == DialogResult.OK)
                {
                    GetDepartmentList();
                }
            }
            else if (name == "删除")
            {
                //友好提示
                MessageBox.Show("确认要删除吗！");

                var i = bll.DelDepartment(id);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                    GetDepartmentList();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }
    }
}