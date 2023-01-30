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
    /// 员工信息Bll
    /// </summary>
    public class StaffBll
    {
        private StaffDal dal = new StaffDal();

        /// <summary>
        /// 绑定一级部门
        /// </summary>
        /// <returns></returns>
        public List<Department> BinDepartmentId()
        {
            var list = dal.BinDepartmentId();
            return list;
        }

        /// <summary>
        /// 绑定一级部门
        /// </summary>
        /// <returns></returns>
        public List<Station> BinStationId()
        {
            var list = dal.BinStationId();
            return list;
        }

        /// <summary>
        /// 添加员工基础信息
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int AddStaff(Staff staff)
        {
            var i = dal.AddStaff(staff);
            return i;
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
            var pageResult = dal.GetStaff(name, pageIndex, pageSize);
            return pageResult;
        }

        /// <summary>
        /// 根据id查询一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffDto GetStaffById(int id)
        {
            var data = dal.GetStaffById(id);
            return data;
        }

        /// <summary>
        /// 编辑一条数据
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int UpdStaff(Staff staff)
        {
            var i = dal.UpdStaff(staff);
            return i;
        }

        public int DelStaff(int id)
        {
            var i = dal.DelStaff(id);
            return i;
        }
    }
}