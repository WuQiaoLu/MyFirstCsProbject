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
    /// 退宿管理Bll
    /// </summary>
    public class StaffStayOutBll
    {
        private StaffStayOutDal dal = new StaffStayOutDal();

        /// <summary>
        /// 绑定人员表（根据姓名进行查询）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StaffStayOutDto> GetStaffList(int id)
        {
            var staffList = dal.GetStaffList(id);
            return staffList;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int AddStaffStayOut(StaffStayOutDto a)
        {
            var i = dal.AddStaffStayOut(a);
            return i;
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
            var pageResult = dal.GetStaffStayOutDto(name, pageIndex, pageSize);
            return pageResult;
        }

        /// <summary>
        /// 根据id查询一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StaffStayOutDto GetStaffStayOutById(int id)
        {
            var data = dal.GetStaffStayOutById(id);
            return data;
        }

        /// <summary>
        /// 编辑一条数据
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public int UpdStaffStayOut(StaffStayOutDto a)
        {
            var i = dal.UpdStaffStayOut(a);
            return i;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelStaffStayOut(int id)
        {
            var i = dal.DelStaffStayOut(id);
            return i;
        }
    }
}