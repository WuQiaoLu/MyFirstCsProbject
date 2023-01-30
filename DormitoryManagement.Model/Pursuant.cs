namespace DormitoryManagement.Model
{
    /// <summary>
    /// 奖惩依据
    /// </summary>
    public class Pursuant
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 依据信息
        /// </summary>
        public string PursuantName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int TypeId { get; set; }
    }
}