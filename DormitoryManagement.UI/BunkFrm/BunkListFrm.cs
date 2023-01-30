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
using DormitoryManagement.BLL.BasicInfo;

namespace DormitoryManagement.UI.BunkFrm
{
    /// <summary>
    /// 床位维护窗体
    /// </summary>
    public partial class BunkListFrm : Form
    {
        private BunkBll bll = new BunkBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public BunkListFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BunkListFrm_Load(object sender, EventArgs e)
        {
            GetBunk();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        public void GetBunk()
        {
            //床位维护信息
            List<DormitoryBunkDto> bunks = bll.GetBunk();

            //不让自动生成列
            this.BunkList.AutoGenerateColumns = false;

            //绑定信息
            this.BunkList.DataSource = bunks;
        }

        /// <summary>
        /// 需要设置单元格内容显示格式触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BunkList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
            AddBunkFrm addBunkFrm = new AddBunkFrm();

            if (addBunkFrm.ShowDialog() == DialogResult.OK)
            {
                GetBunk();
            }
        }

        /// <summary>
        /// 添加列中按钮触发点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BunkList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = BunkList.Columns[e.ColumnIndex].Name;
            int id = (int)BunkList.Rows[e.RowIndex].Cells[0].Value;

            if (name == "编辑")
            {
                var updBunkFrm = new UpdBunkFrm(id);
                if (updBunkFrm.ShowDialog() == DialogResult.OK)
                {
                    GetBunk();
                }
            }
            else if (name == "删除")
            {
                MessageBox.Show("确认要删除吗？");

                var i = bll.DelBunk(id);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                    GetBunk();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }
    }
}