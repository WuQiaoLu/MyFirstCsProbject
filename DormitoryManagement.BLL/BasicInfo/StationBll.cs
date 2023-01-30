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
    /// 二级部门Bll
    /// </summary>
    public class StationBll
    {
        private StationDal dal = new StationDal();

        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <returns></returns>
        public List<Department> BinParentId()
        {
            var list = dal.BinParentId();
            return list;
        }

        /// <summary>
        /// 添加二级部门
        /// </summary>
        /// <returns></returns>
        public int AddStation(Station station)
        {
            var i = dal.AddStation(station);
            return i;
        }

        /// <summary>
        /// 查询显示二级部门
        /// </summary>
        /// <returns></returns>
        public List<StationDto> GetStation()
        {
            var list = dal.GetStation();
            return list;
        }

        /// <summary>
        /// 根据id获取一条二级部门数据
        /// </summary>
        /// <returns></returns>
        public Station GetStationById(int id)
        {
            var data = dal.GetStationById(id);
            return data;
        }

        /// <summary>
        /// 编辑二级部门
        /// </summary>
        /// <returns></returns>
        public int UpdStation(Station station)
        {
            var i = dal.UpdStation(station);
            return i;
        }

        /// <summary>
        /// 删除二级部门
        /// </summary>
        /// <returns></returns>
        public int DelStation(int id)
        {
            var i = dal.DelStation(id);
            return i;
        }
    }
}