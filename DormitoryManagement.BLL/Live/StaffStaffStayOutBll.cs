using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.DAL;
using DormitoryManagement.Common;
using DormitoryManagement.Model;

namespace DormitoryManagement.BLL.Live
{
    /// <summary>
    /// 入住扣款Bll
    /// </summary>
    public class StaffStaffStayOutBll
    {
        private StaffStaffStayOutDal dal = new StaffStaffStayOutDal();

        /// <summary>
        /// 分页查询显示入住扣款信息
        /// </summary>
        /// <param name="QSTime"></param>
        /// <param name="ZZTime"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageResultDto<StaffStaffStayOutDto> GetStaffStaffStayOut(string QSTime, string ZZTime, int pageIndex, int pageSize)
        {
            var list = dal.GetStaffStaffStayOut(QSTime, ZZTime, pageIndex, pageSize);
            return list;
        }

        /// <summary>
        /// 查询导出
        /// </summary>
        /// <param name="QSTime"></param>
        /// <param name="ZZTime"></param>
        /// <returns></returns>
        public List<StaffStaffStayOutDto> GetStaffStayOutDtos(string QSTime, string ZZTime)
        {
            List<StaffStaffStayOutDto> list = dal.GetStaffStayOutDtos(QSTime, ZZTime);
            return list;
        }
    }
}