namespace DormitoryManagement.UI
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Department = new System.Windows.Forms.ToolStripMenuItem();
            this.Station = new System.Windows.Forms.ToolStripMenuItem();
            this.Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.Dormitory = new System.Windows.Forms.ToolStripMenuItem();
            this.Bunk = new System.Windows.Forms.ToolStripMenuItem();
            this.住宿管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffStaffStayOut = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffStayOut = new System.Windows.Forms.ToolStripMenuItem();
            this.Stayout = new System.Windows.Forms.ToolStripMenuItem();
            this.奖惩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖励管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处罚管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DormitoryDetailDTO = new System.Windows.Forms.ToolStripMenuItem();
            this.DormitorystatisticsFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息维护ToolStripMenuItem,
            this.住宿管理ToolStripMenuItem,
            this.奖惩管理ToolStripMenuItem,
            this.统计分析ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息维护ToolStripMenuItem
            // 
            this.基础信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Department,
            this.Station,
            this.Staff,
            this.Dormitory,
            this.Bunk});
            this.基础信息维护ToolStripMenuItem.Name = "基础信息维护ToolStripMenuItem";
            this.基础信息维护ToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.基础信息维护ToolStripMenuItem.Text = "基础信息维护";
            // 
            // Department
            // 
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(291, 44);
            this.Department.Text = "一级部门维护";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // Station
            // 
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(291, 44);
            this.Station.Text = "二级部门维护";
            this.Station.Click += new System.EventHandler(this.Station_Click);
            // 
            // Staff
            // 
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(291, 44);
            this.Staff.Text = "员工维护";
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Dormitory
            // 
            this.Dormitory.Name = "Dormitory";
            this.Dormitory.Size = new System.Drawing.Size(291, 44);
            this.Dormitory.Text = "宿舍维护";
            this.Dormitory.Click += new System.EventHandler(this.Dormitory_Click);
            // 
            // Bunk
            // 
            this.Bunk.Name = "Bunk";
            this.Bunk.Size = new System.Drawing.Size(291, 44);
            this.Bunk.Text = "床位维护";
            this.Bunk.Click += new System.EventHandler(this.Bunk_Click);
            // 
            // 住宿管理ToolStripMenuItem
            // 
            this.住宿管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffCheckIn,
            this.StaffStaffStayOut,
            this.StaffStayOut,
            this.Stayout});
            this.住宿管理ToolStripMenuItem.Name = "住宿管理ToolStripMenuItem";
            this.住宿管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.住宿管理ToolStripMenuItem.Text = "住宿管理";
            // 
            // StaffCheckIn
            // 
            this.StaffCheckIn.Name = "StaffCheckIn";
            this.StaffCheckIn.Size = new System.Drawing.Size(243, 44);
            this.StaffCheckIn.Text = "入住管理";
            this.StaffCheckIn.Click += new System.EventHandler(this.StaffCheckIn_Click);
            // 
            // StaffStaffStayOut
            // 
            this.StaffStaffStayOut.Name = "StaffStaffStayOut";
            this.StaffStaffStayOut.Size = new System.Drawing.Size(243, 44);
            this.StaffStaffStayOut.Text = "住宿扣款";
            this.StaffStaffStayOut.Click += new System.EventHandler(this.StaffStaffStayOut_Click);
            // 
            // StaffStayOut
            // 
            this.StaffStayOut.Name = "StaffStayOut";
            this.StaffStayOut.Size = new System.Drawing.Size(243, 44);
            this.StaffStayOut.Text = "退宿管理";
            this.StaffStayOut.Click += new System.EventHandler(this.StaffStayOut_Click);
            // 
            // Stayout
            // 
            this.Stayout.Name = "Stayout";
            this.Stayout.Size = new System.Drawing.Size(243, 44);
            this.Stayout.Text = "退宿扣款";
            this.Stayout.Click += new System.EventHandler(this.Stayout_Click);
            // 
            // 奖惩管理ToolStripMenuItem
            // 
            this.奖惩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.奖励管理ToolStripMenuItem,
            this.处罚管理ToolStripMenuItem});
            this.奖惩管理ToolStripMenuItem.Name = "奖惩管理ToolStripMenuItem";
            this.奖惩管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.奖惩管理ToolStripMenuItem.Text = "奖惩管理";
            // 
            // 奖励管理ToolStripMenuItem
            // 
            this.奖励管理ToolStripMenuItem.Name = "奖励管理ToolStripMenuItem";
            this.奖励管理ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.奖励管理ToolStripMenuItem.Text = "奖励管理";
            // 
            // 处罚管理ToolStripMenuItem
            // 
            this.处罚管理ToolStripMenuItem.Name = "处罚管理ToolStripMenuItem";
            this.处罚管理ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.处罚管理ToolStripMenuItem.Text = "处罚管理";
            // 
            // 统计分析ToolStripMenuItem
            // 
            this.统计分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DormitoryDetailDTO,
            this.DormitorystatisticsFrm});
            this.统计分析ToolStripMenuItem.Name = "统计分析ToolStripMenuItem";
            this.统计分析ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.统计分析ToolStripMenuItem.Text = "统计分析";
            // 
            // DormitoryDetailDTO
            // 
            this.DormitoryDetailDTO.Name = "DormitoryDetailDTO";
            this.DormitoryDetailDTO.Size = new System.Drawing.Size(359, 44);
            this.DormitoryDetailDTO.Text = "住宿统计";
            this.DormitoryDetailDTO.Click += new System.EventHandler(this.DormitoryDetailDTO_Click);
            // 
            // DormitorystatisticsFrm
            // 
            this.DormitorystatisticsFrm.Name = "DormitorystatisticsFrm";
            this.DormitorystatisticsFrm.Size = new System.Drawing.Size(359, 44);
            this.DormitorystatisticsFrm.Text = "汇总统计";
            this.DormitorystatisticsFrm.Click += new System.EventHandler(this.DormitorystatisticsFrm_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 1271);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鹭航宿舍管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Department;
        private System.Windows.Forms.ToolStripMenuItem Station;
        private System.Windows.Forms.ToolStripMenuItem Staff;
        private System.Windows.Forms.ToolStripMenuItem Dormitory;
        private System.Windows.Forms.ToolStripMenuItem Bunk;
        private System.Windows.Forms.ToolStripMenuItem 住宿管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaffCheckIn;
        private System.Windows.Forms.ToolStripMenuItem StaffStaffStayOut;
        private System.Windows.Forms.ToolStripMenuItem StaffStayOut;
        private System.Windows.Forms.ToolStripMenuItem Stayout;
        private System.Windows.Forms.ToolStripMenuItem 奖惩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖励管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 处罚管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DormitoryDetailDTO;
        private System.Windows.Forms.ToolStripMenuItem DormitorystatisticsFrm;
    }
}