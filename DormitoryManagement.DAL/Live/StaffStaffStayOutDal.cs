using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Model;
using DormitoryManagement.Common;
using System.Net;

namespace DormitoryManagement.DAL
{
    /// <summary>
    /// 入住扣款Dal
    /// </summary>
    public class StaffStaffStayOutDal
    {
        /// <summary>
        /// 分页查询显示入住扣款信息
        /// </summary>
        /// <param name="QSTime"></param>
        /// <param name="ZZTime"></param>
        /// <param name="totalCount"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageResultDto<StaffStaffStayOutDto> GetStaffStaffStayOut(string QSTime, string ZZTime, int pageIndex, int pageSize)
        {
            try
            {
                string cmdString = $"select ROW_NUMBER()over(order by a.Id)rowId, a.Id,a.Name,a.Sex,a.TypeId,a.EmpNo,a.EntryTime,b.StairName,c.SecondName,d.CheckInTime,d.Money from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where d.Money>0";

                string CountString = $"select count(*) from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where d.Money>0";

                if (!string.IsNullOrEmpty(QSTime) && !string.IsNullOrEmpty(ZZTime))
                {
                    cmdString += $"and CheckInTime between '{QSTime}' and '{ZZTime}'";
                    CountString += $"and CheckInTime between '{QSTime}' and '{ZZTime}'";
                }
                //计算总记录数
                int totalCount = (int)DapperHelper.ExecuteScalar(CountString);
                string pageText = $"select * from ({cmdString}) as q where q.rowId between {pageSize * (pageIndex - 1) + 1} and {pageIndex * pageSize}";
                var list = DapperHelper.GetList<StaffStaffStayOutDto>(pageText);
                PageResultDto<StaffStaffStayOutDto> staffStaffStayOutDto = new PageResultDto<StaffStaffStayOutDto>()
                {
                    ItemCount = totalCount,
                    Items = list
                };
                return staffStaffStayOutDto;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 查询导出
        /// </summary>
        /// <param name="QSTime"></param>
        /// <param name="ZZTime"></param>
        /// <returns></returns>
        public List<StaffStaffStayOutDto> GetStaffStayOutDtos(string QSTime, string ZZTime)
        {
            try
            {
                string cmdString = $"select ROW_NUMBER()over(order by a.Id)rowId, a.Id,a.Name,a.Sex,a.TypeId,a.EmpNo,a.EntryTime,b.StairName,c.SecondName,d.CheckInTime,d.Money from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where d.Money>0";

                if (!string.IsNullOrEmpty(QSTime) && !string.IsNullOrEmpty(ZZTime))
                {
                    cmdString += $"and CheckInTime between '{QSTime}' and '{ZZTime}'";
                }
                List<StaffStaffStayOutDto> list = DapperHelper.GetList<StaffStaffStayOutDto>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}