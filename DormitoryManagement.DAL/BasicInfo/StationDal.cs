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
    /// 二级部门Dal
    /// </summary>
    public class StationDal
    {
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <returns></returns>
        public List<Department> BinParentId()
        {
            try
            {
                string cmdString = $"select Id,StairName from Department";
                var list = DapperHelper.GetList<Department>(cmdString);
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 添加二级部门
        /// </summary>
        /// <returns></returns>
        public int AddStation(Station station)
        {
            try
            {
                string cmdString = $"insert into Station values ('{station.SecondName}','{station.ParentId}','{station.IsEnable}')";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 查询显示二级部门
        /// </summary>
        /// <returns></returns>
        public List<StationDto> GetStation()
        {
            try
            {
                string cmdString = $"select a.* ,b.StairName from Station  a join Department b on a.ParentId=b.Id";
                var list = DapperHelper.GetList<StationDto>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据id获取一条二级部门数据
        /// </summary>
        /// <returns></returns>
        public Station GetStationById(int id)
        {
            try
            {
                string cmdString = $"select * from Station where Id={id}";
                var data = DapperHelper.GetList<Station>(cmdString).FirstOrDefault();
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 编辑二级部门
        /// </summary>
        /// <returns></returns>
        public int UpdStation(Station station)
        {
            try
            {
                string cmdString = $"update Station set SecondName='{station.SecondName}',ParentId='{station.ParentId}',IsEnable='{station.IsEnable}' where Id='{station.Id}'";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 删除二级部门
        /// </summary>
        /// <returns></returns>
        public int DelStation(int id)
        {
            try
            {
                string cmdDtring = $"delete from Station where Id={id}";
                var i = DapperHelper.ExecuteSQL(cmdDtring);
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}