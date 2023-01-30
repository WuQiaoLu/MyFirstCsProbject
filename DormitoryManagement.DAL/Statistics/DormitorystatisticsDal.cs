using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Model;
using DormitoryManagement.Common;

namespace DormitoryManagement.DAL
{
    /// <summary>
    /// 统计汇总Dal
    /// </summary>
    public class DormitorystatisticsDal
    {
        /// <summary>
        /// 从数据库中进行汇总统计
        /// </summary>
        /// <returns></returns>
        public List<DormitoryStatisticsDto> GetDormitoriesDto1()
        {
            try
            {
                string cmdString = $"exec p_TotalBormitorys";
                var list = DapperHelper.GetList<DormitoryStatisticsDto>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}