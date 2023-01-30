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
    /// 住宿统计Dal
    /// </summary>
    public class DormitoryDetailDTODal
    {
        /// <summary>
        /// 综合查询页面的汇总信息
        /// </summary>
        /// <returns></returns>
        public TotalRoomDto GetRoomDto()
        {
            try
            {
                string cmdString = $"exec p_totalRoom";
                var list = DapperHelper.GetList<TotalRoomDto>(cmdString).FirstOrDefault();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 查询房间、住宿明细
        /// </summary>
        /// <returns></returns>
        public List<DormitoryDetailDTO> GetDormitoryDetailDTO()
        {
            try
            {
                string cmdStriing = $" exec p_queryroomandbed ";
                var list = DapperHelper.GetList<DormitoryDetailDTO>(cmdStriing);
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}