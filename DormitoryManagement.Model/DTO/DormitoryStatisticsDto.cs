using System;

namespace DormitoryManagement.Model
{
    public class DormitoryStatisticsDto
    {
        /// <summary>
        /// 宿舍统计
        /// </summary>
        public string dormitory { get; set; }

        /// <summary>
        /// 总床位
        /// </summary>
        public int bed { get; set; }

        /// <summary>
        /// 入住人数
        /// </summary>
        public int Checkin { get; set; }

        /// <summary>
        /// 剩余人数
        /// </summary>
        public int surplus { get; set; }

        /// <summary>
        /// 本周入住
        /// </summary>
        public int weekCheck { get; set; }

        /// <summary>
        /// 本周退宿
        /// </summary>
        public int Stayout { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime ks { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime js { get; set; }
    }
}