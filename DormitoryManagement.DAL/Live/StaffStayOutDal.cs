using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Model;
using DormitoryManagement.Common;
using System.Collections;

namespace DormitoryManagement.DAL
{
    /// <summary>
    /// 退宿管理Dal
    /// </summary>
    public class StaffStayOutDal
    {
        /// <summary>
        /// 绑定人员表（根据姓名进行查询）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffStayOutDto> GetStaffList(int id)
        {
            try
            {
                var staffList = new List<StaffStayOutDto>();

                string cmdString = "";

                if (id == 0)
                {
                    cmdString = $"select a.*,b.StairName,c.SecondName,d.Id as CheckInId,d.Treaty,d.Access,d.TowerParent,d.DormParent from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where a.Id not in(select StaffId from StaffStayOut)";
                    staffList = DapperHelper.GetList<StaffStayOutDto>(cmdString);
                    return staffList;
                }
                else
                {
                    cmdString = $"select a.*,b.StairName,c.SecondName,d.CheckInTime,d.TowerParent,d.DormParent,d.Treaty,d.Access from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where a.Id='{id}'";
                    staffList = DapperHelper.GetList<StaffStayOutDto>(cmdString);
                    return staffList;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 添加数据AddStaffStayOut
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int AddStaffStayOut(StaffStayOutDto staff)
        {
            try
            {
                var firstId = $"select * from StaffCheckIn where StaffId = {staff.StaffId}";
                var data = DapperHelper.GetList<StaffCheckIn>(firstId);
                string cmdText = $"insert into StaffStayOut(StaffId,CheckInId,StayOutTime,Deduction) values('{staff.StaffId}','{data[0].Id}','{staff.StayOutTime}','{staff.Deduction}')";
                var i = DapperHelper.ExecuteSQL(cmdText);
                cmdText = $"update StaffCheckIn set IsEnable=0 where StaffId={data[0].StaffId}";
                i = DapperHelper.ExecuteSQL(cmdText);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 分页查询列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageResultDto<StaffStayOutDto> GetStaffStayOutDto(string name, int pageIndex, int pageSize)
        {
            PageResultDto<StaffStayOutDto> pageResult = new PageResultDto<StaffStayOutDto>();

            try
            {
                //列表显示
                string cmdString = $"select  ROW_Number() over(order by A.Id) as rowId,A.Id,C.Name,C.Sex,C.TypeId,C.EmpNo,F.StairName,G.SecondName,B.Treaty,B.Access,B.CheckInTime,A.StayOutTime,A.Deduction,B.TowerParent,B.DormParent,D.DormitoryNo,E.BunkNo from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where 1=1 ";

                //计算总记录数
                string CountString = $"select count(*) from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where 1=1 ";

                //条件查询
                if (!string.IsNullOrEmpty(name))
                {
                    cmdString += $"and C.Name like '%{name}%'";
                    CountString += $"and C.Name like '%{name}%'";
                }

                //总计录数
                pageResult.ItemCount = (int)DapperHelper.ExecuteScalar(CountString);

                //分页
                string pageString = $"select * from ({cmdString})as t1 where t1.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";

                //数据结果
                pageResult.Items = DapperHelper.GetList<StaffStayOutDto>(pageString);
                return pageResult;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据id查询一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffStayOutDto GetStaffStayOutById(int id)
        {
            try
            {
                string cmdString = $"select A.Id,A.StaffId,C.Name,C.Sex,C.TypeId,C.EmpNo,F.StairName,G.SecondName,C.Mobile,C.EmergencyName,C.EmergencyMobile,B.Treaty,B.Access,B.CheckInTime,A.StayOutTime,A.Deduction,B.TowerParent,B.DormParent,D.DormitoryNo,E.BunkNo from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where A.Id={id}";
                var data = DapperHelper.GetList<StaffStayOutDto>(cmdString).FirstOrDefault();
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 编辑一条数据
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int UpdStaffStayOut(StaffStayOutDto staff)
        {
            try
            {
                var firstId = $"select * from StaffCheckIn where StaffId = {staff.StaffId}";
                var data = DapperHelper.GetList<StaffCheckIn>(firstId);
                string cmdText = $"update StaffStayOut set StaffId='{staff.StaffId}',CheckInId='{data[0].Id}',StayOutTime='{staff.StayOutTime}',Deduction='{staff.Deduction}' where Id='{staff.Id}'";
                var i = DapperHelper.ExecuteSQL(cmdText);
                cmdText = $"update StaffCheckIn set IsEnable=0 where StaffId={data[0].StaffId}";
                i = DapperHelper.ExecuteSQL(cmdText);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelStaffStayOut(int id)
        {
            try
            {
                string cmdString = $"delete from StaffStayOut where Id='{id}'";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}