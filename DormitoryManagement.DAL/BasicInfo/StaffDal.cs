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
    /// 员工基础信息Dal
    /// </summary>
    public class StaffDal
    {
        /// <summary>
        /// 绑定一级部门
        /// </summary>
        /// <returns></returns>
        public List<Department> BinDepartmentId()
        {
            try
            {
                string cmdString = $"select Id,StairName from Department";
                var list = DapperHelper.GetList<Department>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 绑定一级部门
        /// </summary>
        /// <returns></returns>
        public List<Station> BinStationId()
        {
            try
            {
                string cmdString = $"select Id,SecondName from Station";
                var list = DapperHelper.GetList<Station>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 添加员工基础信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int AddStaff(Staff staff)
        {
            try
            {
                string cmdString = $"insert into Staff values ('{staff.Name}','{staff.Sex}','{staff.TypeId}','{staff.EmpNo}','{staff.DepartmentId}','{staff.StationId}','{staff.IDCard}','{staff.Mobile}','{staff.EmergencyName}','{staff.EmergencyMobile}','{staff.EntryTime}','{staff.IsResidence}','{staff.IsEnable}')";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageResultDto<StaffDto> GetStaff(string name, int pageIndex, int pageSize)
        {
            PageResultDto<StaffDto> pageResult = new PageResultDto<StaffDto>();

            try
            {
                //列表显示
                string cmdString = $"select ROW_NUMBER() over(order by a.Id)as rowId,a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where 1=1 ";

                //计算总记录数
                string CountString = $"select count(*) from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where 1=1";

                //条件查询
                if (!string.IsNullOrEmpty(name))
                {
                    cmdString += $"and a.Name like '%{name}%'";
                    CountString += $"and a.Name like '%{name}%'";
                }

                //总计录数
                pageResult.ItemCount = (int)DapperHelper.ExecuteScalar(CountString);

                //分页
                string pageString = $"select * from ({cmdString})as t where t.rowId between {(pageIndex - 1) * pageSize + 1} and {pageIndex * pageSize}";

                //数据结果
                pageResult.Items = DapperHelper.GetList<StaffDto>(pageString);
            }
            catch (Exception)
            {
                return null;
            }
            return pageResult;
        }

        /// <summary>
        /// 根据id查询一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffDto GetStaffById(int id)
        {
            try
            {
                string cmdString = $"select a.*,b.StairName,c.SecondName  from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id='{id}'";
                var data = DapperHelper.GetList<StaffDto>(cmdString).FirstOrDefault();
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
        public int UpdStaff(Staff staff)
        {
            try
            {
                string cmdString = $"update Staff set Name='{staff.Name}',Sex='{staff.Sex}',TypeId='{staff.TypeId}',EmpNo='{staff.EmpNo}',DepartmentId='{staff.DepartmentId}',StationId='{staff.StationId}',IDCard='{staff.IDCard}',EmergencyName='{staff.EmergencyName}',EmergencyMobile='{staff.EmergencyMobile}',EntryTime='{staff.EntryTime}',IsResidence='{staff.IsResidence}',IsEnable='{staff.IsEnable}'  where Id='{staff.Id}'";
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
        public int DelStaff(int id)
        {
            try
            {
                string cmdString = $"delete from Staff where Id='{id}'";
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