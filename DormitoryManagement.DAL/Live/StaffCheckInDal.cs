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
    /// 入驻管理Dal
    /// </summary>
    public class StaffCheckInDal
    {
        /// <summary>
        /// 绑定人员表（根据姓名进行查询）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffDto> GetStaffById(int id)
        {
            try
            {
                var staffList = new List<StaffDto>();

                string cmdString = "";

                if (id == 0)
                {
                    cmdString = $"select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id not in(select StaffId from StaffCheckIn) and a.IsEnable=1";
                    staffList = DapperHelper.GetList<StaffDto>(cmdString);
                    return staffList;
                }
                else
                {
                    cmdString = $"select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id='{id}'";
                    staffList = DapperHelper.GetList<StaffDto>(cmdString);
                    return staffList;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 绑定宿舍表
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitory()
        {
            try
            {
                string cmdString = $"select Id,DormitoryNo from Dormitory";
                var list = DapperHelper.GetList<Dormitory>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 绑定宿舍下的床位表
        /// </summary>
        /// <returns></returns>
        public List<Bunk> GetBunk(int id)
        {
            try
            {
                string cmdString = $"select * from Bunk where DormitoryId='{id}'";
                var list = DapperHelper.GetList<Bunk>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int AddStaffCheckIn(StaffCheckIn m)
        {
            try
            {
                string cmdString = $"insert into StaffCheckIn values('{m.StaffId}','{m.Money}','{m.Treaty}','{m.Access}','{m.TowerParent}','{m.DormParent}','{m.CheckInTime}','{m.DormitoryId}','{m.BunkId}','{m.IsEnable}')";
                var i = DapperHelper.ExecuteSQL(cmdString);
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
        public PageResultDto<StaffCheckInDto> GetStaffCheckIn(string name, int pageIndex, int pageSize)
        {
            PageResultDto<StaffCheckInDto> pageResult = new PageResultDto<StaffCheckInDto>();

            try
            {
                //列表显示
                string cmdString = $"select ROW_NUMBER() over(order by a.Id)as rowId,a.*,b.EmergencyMobile,b.EmergencyName,b.EmpNo,b.EntryTime,b.IDCard,b.IsResidence,b.Mobile,b.Name,b.Sex,b.TypeId,c.DormitoryNo,d.BunkNo from StaffCheckIn a join Staff b on a.StaffId=b.Id join Dormitory c on a.DormitoryId=c.Id join Bunk d on a.BunkId=d.Id where 1=1";

                //计算总记录数
                string CountString = $"select count(*) from StaffCheckIn a join Staff b on a.StaffId=b.Id join Dormitory c on a.DormitoryId=c.Id join Bunk d on a.BunkId=d.Id where 1=1";

                //条件查询
                if (!string.IsNullOrEmpty(name))
                {
                    cmdString += $"and b.Name like '%{name}%'";
                    CountString += $"and b.Name like '%{name}%'";
                }

                //总计录数
                pageResult.ItemCount = (int)DapperHelper.ExecuteScalar(CountString);

                //分页
                string pageString = $"select * from ({cmdString})as t1 where t1.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";

                //数据结果
                pageResult.Items = DapperHelper.GetList<StaffCheckInDto>(pageString);
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
        public StaffCheckInDto GetStaffCheckInById(int id)
        {
            try
            {
                string cmdString = $"select t1.*,t2.Name,t2.EmpNo,t2.Sex,t2.TypeId,t2.Mobile,t2.EmergencyName,t2.EmergencyMobile,t3.StairName,t4.SecondName,t5.BunkNo from StaffCheckIn t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id join Bunk t5 on t1.BunkId=t5.Id where t1.Id='{id}'";
                var data = DapperHelper.GetList<StaffCheckInDto>(cmdString).FirstOrDefault();
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
        public int UpdStaffCheckIn(StaffCheckIn a)
        {
            try
            {
                string cmdString = $"update StaffCheckIn set StaffId='{a.StaffId}',Money='{a.Money}',Treaty='{a.Treaty}',Access='{a.Access}',TowerParent='{a.TowerParent}',DormParent='{a.DormParent}',CheckInTime='{a.CheckInTime}',DormitoryId='{a.DormitoryId}',BunkId='{a.BunkId}',IsEnable='{a.IsEnable}' where Id='{a.Id}'";
                var i = DapperHelper.ExecuteSQL(cmdString);
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
        public int DelStaffCheckIn(int id)
        {
            try
            {
                string cmdString = $"delete from StaffCheckIn where Id='{id}'";
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