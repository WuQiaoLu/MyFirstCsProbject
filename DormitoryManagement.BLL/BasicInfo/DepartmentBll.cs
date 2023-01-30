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
    /// 一级部门Bll
    /// </summary>
    public class DepartmentBll
    {
        private DepartmentDal dal = new DepartmentDal();

        /// <summary>
        /// 添加一级部门信息
        /// </summary>
        /// <returns></returns>
        public int AddDepartment(Department department)
        {
            var i = dal.AddDepartment(department);
            return i;
        }

        /// <summary>
        /// 查询一级部门信息（列表）
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartment()
        {
            var list = dal.GetDepartment();
            return list;
        }

        /// <summary>
        /// 根据id获取一条以及部门信息
        /// </summary>
        /// <returns></returns>
        public Department GetDepartmentById(int id)
        {
            var data = dal.GetDepartmentById(id);
            return data;
        }

        /// <summary>
        /// 编辑一级部门信息
        /// </summary>
        /// <returns></returns>
        public int UpdDepartment(Department department)
        {
            var i = dal.UpdDepartment(department);
            return i;
        }

        /// <summary>
        /// 删除一条一级部门信息
        /// </summary>
        /// <returns></returns>
        public int DelDepartment(int id)
        {
            var i = dal.DelDepartment(id);
            return i;
        }
    }
}