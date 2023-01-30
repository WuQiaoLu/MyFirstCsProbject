namespace DormitoryManagement.Model
{
    /// <summary>
    /// 奖惩事项
    /// </summary>
    public class Matter
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 事项信息
        /// </summary>
        public string MatterName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int TypeId { get; set; }
    }
}