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
    /// 宿舍管理Bll
    /// </summary>
    public class DormitoryBll
    {
        private DormitoryDal dal = new DormitoryDal();

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="dormitory"></param>
        /// <returns></returns>
        public int AddDormitory(Dormitory dormitory)
        {
            var i = dal.AddDormitory(dormitory);
            return i;
        }

        /// <summary>
        /// 宿舍列表
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitory()
        {
            var list = dal.GetDormitory();
            return list;
        }

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dormitory GetDormitoryById(int id)
        {
            var data = dal.GetDormitoryById(id);
            return data;
        }

        /// <summary>
        /// 编辑一条数据
        /// </summary>
        /// <param name="dormitory"></param>
        /// <returns></returns>
        public int UpdDormitory(Dormitory dormitory)
        {
            var i = dal.UpdDormitory(dormitory);
            return i;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelDormitory(int id)
        {
            var i = dal.DelDormitory(id);
            return i;
        }
    }
}