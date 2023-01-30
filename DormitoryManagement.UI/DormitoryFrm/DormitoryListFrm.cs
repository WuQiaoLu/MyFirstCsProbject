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

namespace DormitoryManagement.UI.DormitoryFrm
{
    /// <summary>
    /// 宿舍维护列表窗体
    /// </summary>
    public partial class DormitoryListFrm : Form
    {
        private DormitoryBll bll = new DormitoryBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public DormitoryListFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（单击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitoryListFrm_Load(object sender, EventArgs e)
        {
            GetDormitory();
        }

        public void GetDormitory()
        {
            //宿舍信息
            List<Dormitory> dormitories = bll.GetDormitory();

            //不让自动生成列
            this.DormitoryList.AutoGenerateColumns = false;

            //绑定信息
            this.DormitoryList.DataSource = dormitories;
        }

        /// <summary>
        /// 需要设置单元格内容显示格式触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitoryList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "男寝";
                }
                else
                {
                    e.Value = "女寝";
                }
            }

            if (e.ColumnIndex == 3)
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
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            AddDormitoryFrm addDormitoryFrm = new AddDormitoryFrm();

            if (addDormitoryFrm.ShowDialog() == DialogResult.OK)
            {
                GetDormitory();
            }
        }

        /// <summary>
        /// 点击行内按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = DormitoryList.Columns[e.ColumnIndex].Name;
            int id = (int)DormitoryList.Rows[e.RowIndex].Cells[0].Value;
            if (name == "编辑")
            {
                UpdDormitoryFrm updDormitoryFrm = new UpdDormitoryFrm(id);

                if (updDormitoryFrm.ShowDialog() == DialogResult.OK)
                {
                    GetDormitory();
                }
            }
            if (name == "删除")
            {
                //友好提示
                MessageBox.Show("确认要删除吗？");

                var i = bll.DelDormitory(id);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                    GetDormitory();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }
    }
}