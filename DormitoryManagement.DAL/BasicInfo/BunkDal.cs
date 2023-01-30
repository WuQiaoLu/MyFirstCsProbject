using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Model;
using DormitoryManagement.Common;

namespace DormitoryManagement.DAL.BasicInfo
{
    /// <summary>
    /// 床位维护Dal
    /// </summary>
    public class BunkDal
    {
        /// <summary>
        /// 获取宿舍表信息
        /// </summary>
        /// <returns></returns>
        public List<Dormitory> GetDormitory()
        {
            try
            {
                string cmdString = $"select Id,DormitoryNo from Dormitory";
                var list = DapperHelper.GetList<Dormitory>(cmdString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 添加床位
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int AddBunk(Bunk bunk)
        {
            try
            {
                string cmdString = $"insert into Bunk values ('{bunk.BunkNo}','{bunk.DormitoryId}','{bunk.IsEnable}')";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// 查询显示
        /// </summary>
        /// <returns></returns>
        public List<DormitoryBunkDto> GetBunk()
        {
            try
            {
                string cmdString = $"select a.*,b.DormitoryNo from Bunk a join Dormitory b on a.DormitoryId=b.Id where 1=1";
                var list = DapperHelper.GetList<DormitoryBunkDto>(cmdString);
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
        public Bunk GetBunkByid(int id)
        {
            try
            {
                string cmdString = $"select * from Bunk where Id='{id}'";
                var data = DapperHelper.GetList<Bunk>(cmdString).FirstOrDefault();
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 编辑床位表
        /// </summary>
        /// <param name="bunk"></param>
        /// <returns></returns>
        public int UpdBunk(Bunk bunk)
        {
            try
            {
                String cmdString = $"update Bunk set BunkNo='{bunk.BunkNo}',DormitoryId='{bunk.DormitoryId}',IsEnable='{bunk.IsEnable}' where Id='{bunk.Id}'";
                var i = DapperHelper.ExecuteSQL(cmdString);
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 删除一条床位信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelBunk(int id)
        {
            try
            {
                String cmdString = $"delete from Bunk where Id='{id}'";
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