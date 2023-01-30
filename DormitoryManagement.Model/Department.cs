﻿namespace DormitoryManagement.Model
{
    /// <summary>
    /// 一级部门表
    /// </summary>
    public class Department
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string StairName { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>

        public bool IsEnable { get; set; }
    }
}