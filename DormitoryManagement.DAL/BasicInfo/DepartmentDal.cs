using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Common;
using DormitoryManagement.Model;

namespace DormitoryManagement.DAL
{
    /// <summary>
    /// 一级部门Dal
    /// </summary>
    public class DepartmentDal
    {
        /// <summary>
        /// 添加一级部门信息
        /// </summary>
        /// <returns></returns>
        public int AddDepartment(Department department)
        {
            try
            {
                string cmdString = $"insert into Department values ('{department.StairName}','{department.IsEnable}')";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 查询一级部门信息（列表）
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartment()
        {
            try
            {
                string cmdString = $"select * from Department";
                var list = DapperHelper.GetList<Department>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据id获取一条以及部门信息
        /// </summary>
        /// <returns></returns>
        public Department GetDepartmentById(int id)
        {
            try
            {
                string cmdString = $"select * from Department where Id={id}";
                var data = DapperHelper.GetList<Department>(cmdString).FirstOrDefault();
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 编辑一级部门信息
        /// </summary>
        /// <returns></returns>
        public int UpdDepartment(Department department)
        {
            try
            {
                string cmdString = $"update Department set StairName='{department.StairName}',IsEnable='{department.IsEnable}' where Id='{department.Id}'";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 删除一条一级部门信息
        /// </summary>
        /// <returns></returns>
        public int DelDepartment(int id)
        {
            try
            {
                string cmdString = $"delete from Department where Id={id}";
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