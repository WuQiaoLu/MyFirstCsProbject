using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Model;
using DormitoryManagement.DAL;
using DormitoryManagement.Common;

namespace DormitoryManagement.BLL
{
    /// <summary>
    /// 住宿统计Bll
    /// </summary>
    public class DormitoryDetailDTOBll
    {
        private DormitoryDetailDTODal dal = new DormitoryDetailDTODal();

        /// <summary>
        /// 综合查询页面的汇总信息
        /// </summary>
        /// <returns></returns>
        public TotalRoomDto GetRoomDto()
        {
            var list = dal.GetRoomDto();
            return list;
        }

        /// <summary>
        /// 查询房间、住宿明细
        /// </summary>
        /// <returns></returns>
        public List<DormitoryDetailDTO> GetDormitoryDetailDTO()
        {
            var list = dal.GetDormitoryDetailDTO();
            return list;
        }
    }
}