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
using System.Windows.Forms.DataVisualization.Charting;

namespace DormitoryManagement.UI.DormitoryDetailDTOFrm
{
    /// <summary>
    /// 统计汇总窗体
    /// </summary>
    public partial class DormitorystatisticsFrm : Form
    {
        private DormitorystatisticsBll bll = new DormitorystatisticsBll();

        /// <summary>
        /// 页面初始化加载窗体
        /// </summary>
        public DormitorystatisticsFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 类似于文档就绪函数（点击边框生成 ）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DormitorystatisticsFrm_Load(object sender, EventArgs e)
        {
            ShowStaff();
            InitChart();
            BindData();
        }

        /// <summary>
        /// 显示查询
        /// </summary>
        private void ShowStaff()
        {
            List<DormitoryStatisticsDto> list = bll.GetDormitoriesDto1();
            this.TotalBormitorys.AutoGenerateColumns = false;
            this.TotalBormitorys.DataSource = list;
        }

        /// <summary>
        /// 初始化Chart图形
        /// </summary>
        private void InitChart()
        {
            chart1.Series.Clear();
            ChartHelper.AddSeries(chart1, "男生曲线图", SeriesChartType.Spline, Color.Blue, Color.Blue, true);
            ChartHelper.AddSeries(chart1, "女生曲线图", SeriesChartType.Spline, Color.Red, Color.Red);
            ChartHelper.SetTitle(chart1, "男女宿舍显示", new Font("微软雅黑", 12), Docking.Bottom, Color.Black);
            ChartHelper.SetStyle(chart1, Color.Transparent, Color.Black);
            ChartHelper.SetLegend(chart1, Docking.Top, StringAlignment.Center, Color.Transparent, Color.Black);
            ChartHelper.SetXY(chart1, "序号", "数值", StringAlignment.Far, Color.Black, Color.Black, AxisArrowStyle.SharpTriangle, 1, 2);
            ChartHelper.SetMajorGrid(chart1, Color.Gray, 20, 2);

            chart2.Series.Clear();
            ChartHelper.AddSeries(chart2, "饼图", SeriesChartType.Pie, Color.Blue, Color.Red, true);
            ChartHelper.SetTitle(chart2, "汇总统计", new Font("微软雅黑", 12), Docking.Bottom, Color.Black);
            ChartHelper.SetStyle(chart2, Color.Transparent, Color.Black);
            ChartHelper.SetLegend(chart2, Docking.Top, StringAlignment.Center, Color.Transparent, Color.Black);
            ChartHelper.SetMajorGrid(chart2, Color.Gray, 20, 2);
        }

        /// <summary>
        /// 动态绑定Chart的数据
        /// </summary>
        public void BindData()
        {
            List<string> x1 = new List<string>() { "总床位数", "入住总人数", "剩余人数", "本周入住", "本周退宿" };
            List<DormitoryStatisticsDto> chart1List = bll.GetDormitoriesDto1();

            List<int> y1 = new List<int>();
            List<int> y2 = new List<int>();
            List<int> y3 = new List<int>();

            y1.Add(chart1List[0].bed);
            y1.Add(chart1List[0].Checkin);
            y1.Add(chart1List[0].surplus);
            y1.Add(chart1List[0].weekCheck);
            y1.Add(chart1List[0].Stayout);

            y2.Add(chart1List[1].bed);
            y2.Add(chart1List[1].Checkin);
            y2.Add(chart1List[1].surplus);
            y2.Add(chart1List[1].weekCheck);
            y2.Add(chart1List[1].Stayout);

            y3.Add(chart1List[2].bed);
            y3.Add(chart1List[2].Checkin);
            y3.Add(chart1List[2].surplus);
            y3.Add(chart1List[2].weekCheck);
            y3.Add(chart1List[2].Stayout);

            chart1.Series[0].Points.DataBindXY(x1, y1);
            chart1.Series[1].Points.DataBindXY(x1, y2);

            chart2.Series[0].Points.DataBindXY(x1, y3);
        }
    }
}