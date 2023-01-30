using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Common;
using DormitoryManagement.DAL;
using DormitoryManagement.DAL.BasicInfo;
using DormitoryManagement.Model;

namespace DormitoryManagement.BLL.BasicInfo
{
    /// <summary>
    /// 床位维护Bll
    /// </summary>
    public class BunkBll
    {
        private BunkDal dal = new BunkDal();

        /// <summary>
        /// 获取宿舍表信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitory()
        {
            var list = dal.GetDormitory();
            return list;
        }

        /// <summary>
        /// 添加床位
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int AddBunk(Bunk bunk)
        {
            var i = dal.AddBunk(bunk);
            return i;
        }

        /// <summary>
        /// 查询显示
        /// </summary>
        /// <returns></returns>
        public List<DormitoryBunkDto> GetBunk()
        {
            var list = dal.GetBunk();
            return list;
        }

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Bunk GetBunkByid(int id)
        {
            var data = dal.GetBunkByid(id);
            return data;
        }

        /// <summary>
        /// 编辑床位表
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int UpdBunk(Bunk bunk)
        {
            var i = dal.UpdBunk(bunk);
            return i;
        }

        /// <summary>
        /// 删除一条床位信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelBunk(int id)
        {
            var i = dal.DelBunk(id);
            return i;
        }
    }
}