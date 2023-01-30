namespace DormitoryManagement.Model
{
    /// <summary>
    /// 宿舍表
    /// </summary>
    public class Dormitory
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 宿舍号
        /// </summary>
        public string DormitoryNo { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 房间类型
        /// </summary>
        public bool DormitoryType { get; set; }
    }
}