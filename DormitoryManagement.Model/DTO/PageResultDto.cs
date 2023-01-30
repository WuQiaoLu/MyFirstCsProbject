using System.Collections.Generic;

namespace DormitoryManagement.Model
{
    /// <summary>
    /// 分页公共类
    /// </summary>
    public class PageResultDto<T>
    {
        /// <summary>
        /// 总条数
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public List<T> Items { get; set; }
    }
}