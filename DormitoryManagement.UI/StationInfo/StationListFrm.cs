using DormitoryManagement.BLL;
using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DormitoryManagement.UI.StationInfo
{
    /// <summary>
    /// 二级部门维护窗体
    /// </summary>
    public partial class StationListFrm : Form
    {
        private StationBll bll = new StationBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public StationListFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationListFrm_Load(object sender, EventArgs e)
        {
            GetStation();
        }

        /// <summary>
        /// 数据库中查询数据绑定
        /// </summary>
        private void GetStation()
        {
            //一级部门信息
            List<StationDto> stations = bll.GetStation();

            //不让自动生成列
            this.StationList.AutoGenerateColumns = false;

            //绑定信息
            this.StationList.DataSource = stations;
        }

        /// <summary>
        /// 需要设置单元格内容显示格式触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
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
            StationAddFrm stationAddFrm = new StationAddFrm();
            if (stationAddFrm.ShowDialog() == DialogResult.OK)
            {
                GetStation();
            }
        }

        /// <summary>
        /// 添加列中按钮触发点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = StationList.Columns[e.ColumnIndex].Name;
            int id = (int)StationList.Rows[e.RowIndex].Cells[0].Value;
            if (name == "编辑")
            {
                var stationUpdFrm = new StationUpdFrm(id);
                //关闭对话弹窗，如果设置对话状态为OK，则刷新父级页面列表数据
                if (stationUpdFrm.ShowDialog() == DialogResult.OK)
                {
                    GetStation();
                }
            }
            else if (name == "删除")
            {
                //友好提示
                MessageBox.Show("确认要删除吗！");

                var i = bll.DelStation(id);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                    GetStation();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }
    }
}