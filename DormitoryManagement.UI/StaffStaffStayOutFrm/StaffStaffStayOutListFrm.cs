using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagement.Model;
using DormitoryManagement.BLL;
using DormitoryManagement.BLL.Live;
using NPOI.HSSF.UserModel;
using DormManage.UI;
using NPOI.SS.UserModel;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace DormitoryManagement.UI.StaffStaffStayOutFrm
{
    /// <summary>
    /// 住宿扣款窗体
    /// </summary>
    public partial class StaffStaffStayOutListFrm : Form
    {
        private StaffStaffStayOutBll bll = new StaffStaffStayOutBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public StaffStaffStayOutListFrm()
        {
            InitializeComponent();
            dpQSTime.Value = Convert.ToDateTime("2021-01-01");
            dpZZTime.Value = Convert.ToDateTime("2023-12-12");
        }

        /// <summary>
        /// 类似于文档就绪函数(点击边框生成)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffStaffStayOutListFrm_Load(object sender, EventArgs e)
        {
            GetStaffStaffStayOut();
        }

        //定义分页变量
        private int pageIndex = 1;//当前页

        private int pageSize = 5;//页容量

        private int pageCount = 0;//总页数

        /// <summary>
        /// 从数据库中获取数据
        /// </summary>
        public void GetStaffStaffStayOut()
        {
            var QSTime = dpQSTime.Value.ToString("yyyy-MM-dd");
            var ZZTimme = dpZZTime.Value.ToString("yyyy-MM-dd");
            PageResultDto<StaffStaffStayOutDto> list = bll.GetStaffStaffStayOut(QSTime, ZZTimme, pageIndex, pageSize);

            //计算总页数
            pageCount = Convert.ToInt32(Math.Ceiling(list.ItemCount * 1.0 / pageSize));
            label3.Text = $"共 {list.ItemCount} 条数据，每页显示 {pageSize} 条，共 {pageCount} 页，当前第 {pageIndex} 页";

            //不让自动生成列
            this.StaffStaffStayOutList.AutoGenerateColumns = false;

            //绑定信息
            this.StaffStaffStayOutList.DataSource = list.Items;
        }

        /// <summary>
        /// 需要设置单元格内容显示格式时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffStaffStayOutList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
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
            if (e.ColumnIndex == 4)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "员工";
                }
                else
                {
                    e.Value = "工人";
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
            GetStaffStaffStayOut();
        }

        /// <summary>
        /// 获取需要导出的数据
        /// </summary>
        /// <returns></returns>
        public List<StaffStaffStayOutDto> GetExportData()
        {
            GetStaffStaffStayOut();
            var QSTime = dpQSTime.Value.ToString();
            var ZZTime = dpZZTime.Value.ToString();
            var list = bll.GetStaffStayOutDtos(QSTime, ZZTime);
            return list;
        }

        /// <summary>
        /// 导出按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExport_Click(object sender, EventArgs e)
        {
            var list = GetExportData();
            if (list.Count <= 0) return;

            //定义工作簿
            HSSFWorkbook workbook = new HSSFWorkbook();
            //创建Sheet表单
            var tital = "宿舍后台管理";
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(tital);
            //设置表单列的宽度
            sheet.DefaultColumnWidth = 20;
            //新建标题行
            HSSFRow dataRow = (HSSFRow)sheet.CreateRow(0);
            dataRow.CreateCell(0).SetCellStyle(workbook, "ID");
            dataRow.CreateCell(1).SetCellStyle(workbook, "工号");
            dataRow.CreateCell(2).SetCellStyle(workbook, "姓名");
            dataRow.CreateCell(3).SetCellStyle(workbook, "性别");
            dataRow.CreateCell(4).SetCellStyle(workbook, "类别");
            dataRow.CreateCell(5).SetCellStyle(workbook, "一级部门");
            dataRow.CreateCell(6).SetCellStyle(workbook, "二级部门");
            dataRow.CreateCell(7).SetCellStyle(workbook, "住宿日期");
            dataRow.CreateCell(8).SetCellStyle(workbook, "退宿日期");
            dataRow.CreateCell(9).SetCellStyle(workbook, "住宿金额");
            dataRow.CreateCell(10).SetCellStyle(workbook, "退款");
            var row = 1;
            list.ForEach(m =>
            {
                dataRow = (HSSFRow)sheet.CreateRow(row); //创建数据行
                dataRow.CreateCell(0).SetCellStyle(workbook, m.Id);
                dataRow.CreateCell(1).SetCellStyle(workbook, m.EmpNo);
                dataRow.CreateCell(2).SetCellStyle(workbook, m.Name);
                var sex = m.Sex ? "男" : "女";
                dataRow.CreateCell(3).SetCellStyle(workbook, sex);
                var typeid = m.TypeId ? "员工" : "工人";
                dataRow.CreateCell(4).SetCellStyle(workbook, typeid);
                dataRow.CreateCell(5).SetCellStyle(workbook, m.StairName);
                dataRow.CreateCell(6).SetCellStyle(workbook, m.SecondName);
                dataRow.CreateCell(7).SetCellStyle(workbook, m.CheckInTime);
                dataRow.CreateCell(8).SetCellStyle(workbook, m.StayOutTime);
                dataRow.CreateCell(9).SetCellStyle(workbook, m.Money);
                dataRow.CreateCell(10).SetCellStyle(workbook, m.Deduction);
                row++;
            });
            var path = "d:/" + tital + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xls";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
                MessageBox.Show("导出数据成功！导出文件位置：" + path, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 首页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            GetStaffStaffStayOut();
        }

        /// <summary>
        /// 上一页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSYY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                GetStaffStaffStayOut();
            }
        }

        /// <summary>
        /// 下一页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbXYY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex++;
                GetStaffStaffStayOut();
            }
        }

        /// <summary>
        /// 尾页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbWY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = pageCount;
            GetStaffStaffStayOut();
        }
    }
}