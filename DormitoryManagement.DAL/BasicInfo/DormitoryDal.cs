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
    /// 宿舍维护Dal
    /// </summary>
    public class DormitoryDal
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="dormitory"></param>
        /// <returns></returns>
        public int AddDormitory(Dormitory dormitory)
        {
            try
            {
                string cmdString = $"insert into Dormitory values ('{dormitory.DormitoryNo}','{dormitory.IsEnable}','{dormitory.DormitoryType}')";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 宿舍列表
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitory()
        {
            try
            {
                string cmdString = $"select * from Dormitory";
                var list = DapperHelper.GetList<Dormitory>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dormitory GetDormitoryById(int id)
        {
            try
            {
                string cmdString = $"select * from Dormitory where Id='{id}'";
                var data = DapperHelper.GetList<Dormitory>(cmdString).FirstOrDefault();
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
        /// <param name="dormitory"></param>
        /// <returns></returns>
        public int UpdDormitory(Dormitory dormitory)
        {
            try
            {
                string cmdString = $"update Dormitory set DormitoryNo='{dormitory.DormitoryNo}',IsEnable='{dormitory.IsEnable}',DormitoryType='{dormitory.DormitoryType}' where Id='{dormitory.Id}'";
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
        public int DelDormitory(int id)
        {
            try
            {
                string cmdDtring = $"delete from Dormitory where Id='{id}'";
                var i = DapperHelper.ExecuteSQL(cmdDtring);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}