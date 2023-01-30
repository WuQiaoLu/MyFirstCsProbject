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
    /// 入住管理bll
    /// </summary>
    public class StaffCheckInBll
    {
        private StaffCheckInDal dal = new StaffCheckInDal();

        /// <summary>
        /// 绑定人员表（根据姓名进行查询）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffDto> GetStaffById(int id)
        {
            var staffList = dal.GetStaffById(id);
            return staffList;
        }

        /// <summary>
        /// 绑定宿舍表
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitory()
        {
            var list = dal.GetDormitory();
            return list;
        }

        /// <summary>
        /// 绑定宿舍下的床位表
        /// </summary>
        /// <returns></returns>
        public List<Bunk> GetBunk(int id)
        {
            var list = dal.GetBunk(id);
            return list;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int AddStaffCheckIn(StaffCheckIn m)
        {
            var i = dal.AddStaffCheckIn(m);
            return i;
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
            var pageResult = dal.GetStaffCheckIn(name, pageIndex, pageSize);
            return pageResult;
        }

        /// <summary>
        /// 根据id查询一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffCheckInDto GetStaffCheckInById(int id)
        {
            var data = dal.GetStaffCheckInById(id);
            return data;
        }

        /// <summary>
        /// 编辑一条数据
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int UpdStaffCheckIn(StaffCheckIn a)
        {
            var i = dal.UpdStaffCheckIn(a);
            return i;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelStaffCheckIn(int id)
        {
            var i = dal.DelStaffCheckIn(id);
            return i;
        }
    }
}