using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Common;
using DormitoryManagement.DAL;
using DormitoryManagement.Model;

namespace DormitoryManagement.BLL
{
    /// <summary>
    /// 汇总统计Bll
    /// </summary>
    public class DormitorystatisticsBll
    {
        private DormitorystatisticsDal dal = new DormitorystatisticsDal();

        /// <summary>
        /// 从数据库中进行汇总统计
        /// </summary>
        /// <returns></returns>
        public List<DormitoryStatisticsDto> GetDormitoriesDto1()
        {
            var list = dal.GetDormitoriesDto1();
            return list;
        }
    }
}