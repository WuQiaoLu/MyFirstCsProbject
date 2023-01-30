namespace DormitoryManagement.UI.StayoutFrm
{
    partial class StayoutListFrm
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
            this.LbSYY = new System.Windows.Forms.LinkLabel();
            this.LbXYY = new System.Windows.Forms.LinkLabel();
            this.LbWY = new System.Windows.Forms.LinkLabel();
            this.StaffStaffStayOutList = new System.Windows.Forms.DataGridView();
            this.LbSY = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.butExport = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.dpZZTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpQSTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一级部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.二级部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住宿日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.退宿日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住宿金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.扣款 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StaffStaffStayOutList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbSYY
            // 
            this.LbSYY.AutoSize = true;
            this.LbSYY.Location = new System.Drawing.Point(893, 46);
            this.LbSYY.Name = "LbSYY";
            this.LbSYY.Size = new System.Drawing.Size(82, 24);
            this.LbSYY.TabIndex = 4;
            this.LbSYY.TabStop = true;
            this.LbSYY.Text = "上一页";
            this.LbSYY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbSYY_LinkClicked);
            // 
            // LbXYY
            // 
            this.LbXYY.AutoSize = true;
            this.LbXYY.Location = new System.Drawing.Point(981, 46);
            this.LbXYY.Name = "LbXYY";
            this.LbXYY.Size = new System.Drawing.Size(82, 24);
            this.LbXYY.TabIndex = 3;
            this.LbXYY.TabStop = true;
            this.LbXYY.Text = "下一页";
            this.LbXYY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbXYY_LinkClicked);
            // 
            // LbWY
            // 
            this.LbWY.AutoSize = true;
            this.LbWY.Location = new System.Drawing.Point(1069, 46);
            this.LbWY.Name = "LbWY";
            this.LbWY.Size = new System.Drawing.Size(58, 24);
            this.LbWY.TabIndex = 2;
            this.LbWY.TabStop = true;
            this.LbWY.Text = "尾页";
            this.LbWY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbWY_LinkClicked);
            // 
            // StaffStaffStayOutList
            // 
            this.StaffStaffStayOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffStaffStayOutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.工号,
            this.姓名,
            this.性别,
            this.类别,
            this.一级部门,
            this.二级部门,
            this.住宿日期,
            this.退宿日期,
            this.住宿金额,
            this.扣款});
            this.StaffStaffStayOutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffStaffStayOutList.Location = new System.Drawing.Point(0, 100);
            this.StaffStaffStayOutList.Name = "StaffStaffStayOutList";
            this.StaffStaffStayOutList.RowHeadersWidth = 82;
            this.StaffStaffStayOutList.RowTemplate.Height = 37;
            this.StaffStaffStayOutList.Size = new System.Drawing.Size(1730, 1054);
            this.StaffStaffStayOutList.TabIndex = 5;
            this.StaffStaffStayOutList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StaffStaffStayOutList_CellFormatting);
            // 
            // LbSY
            // 
            this.LbSY.AutoSize = true;
            this.LbSY.Location = new System.Drawing.Point(829, 46);
            this.LbSY.Name = "LbSY";
            this.LbSY.Size = new System.Drawing.Size(58, 24);
            this.LbSY.TabIndex = 1;
            this.LbSY.TabStop = true;
            this.LbSY.Text = "首页";
            this.LbSY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbSY_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LbSYY);
            this.panel2.Controls.Add(this.LbXYY);
            this.panel2.Controls.Add(this.LbWY);
            this.panel2.Controls.Add(this.LbSY);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1730, 100);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(586, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "共 N 条数据，每页显示 N 条，共 N 页，当前第 N 页";
            // 
            // butExport
            // 
            this.butExport.Location = new System.Drawing.Point(866, 33);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(111, 49);
            this.butExport.TabIndex = 5;
            this.butExport.Text = "导出";
            this.butExport.UseVisualStyleBackColor = true;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(696, 33);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(111, 49);
            this.butSelect.TabIndex = 4;
            this.butSelect.Text = "查询";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // dpZZTime
            // 
            this.dpZZTime.Location = new System.Drawing.Point(436, 45);
            this.dpZZTime.Name = "dpZZTime";
            this.dpZZTime.Size = new System.Drawing.Size(200, 35);
            this.dpZZTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "___";
            // 
            // dpQSTime
            // 
            this.dpQSTime.Location = new System.Drawing.Point(178, 45);
            this.dpQSTime.Name = "dpQSTime";
            this.dpQSTime.Size = new System.Drawing.Size(200, 35);
            this.dpQSTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始时间：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butExport);
            this.panel1.Controls.Add(this.butSelect);
            this.panel1.Controls.Add(this.dpZZTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dpQSTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1730, 100);
            this.panel1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 80;
            // 
            // 工号
            // 
            this.工号.DataPropertyName = "EmpNo";
            this.工号.HeaderText = "工号";
            this.工号.MinimumWidth = 10;
            this.工号.Name = "工号";
            this.工号.Width = 80;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "Name";
            this.姓名.HeaderText = "姓名";
            this.姓名.MinimumWidth = 10;
            this.姓名.Name = "姓名";
            this.姓名.Width = 80;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "Sex";
            this.性别.HeaderText = "性别";
            this.性别.MinimumWidth = 10;
            this.性别.Name = "性别";
            this.性别.Width = 80;
            // 
            // 类别
            // 
            this.类别.DataPropertyName = "TypeId";
            this.类别.HeaderText = "类别";
            this.类别.MinimumWidth = 10;
            this.类别.Name = "类别";
            this.类别.Width = 80;
            // 
            // 一级部门
            // 
            this.一级部门.DataPropertyName = "StairName";
            this.一级部门.HeaderText = "一级部门";
            this.一级部门.MinimumWidth = 10;
            this.一级部门.Name = "一级部门";
            this.一级部门.Width = 80;
            // 
            // 二级部门
            // 
            this.二级部门.DataPropertyName = "SecondName";
            this.二级部门.HeaderText = "二级部门";
            this.二级部门.MinimumWidth = 10;
            this.二级部门.Name = "二级部门";
            this.二级部门.Width = 80;
            // 
            // 住宿日期
            // 
            this.住宿日期.DataPropertyName = "CheckInTime";
            this.住宿日期.HeaderText = "住宿日期";
            this.住宿日期.MinimumWidth = 10;
            this.住宿日期.Name = "住宿日期";
            this.住宿日期.Width = 80;
            // 
            // 退宿日期
            // 
            this.退宿日期.DataPropertyName = "StayOutTime";
            this.退宿日期.HeaderText = "退宿日期";
            this.退宿日期.MinimumWidth = 10;
            this.退宿日期.Name = "退宿日期";
            this.退宿日期.Width = 80;
            // 
            // 住宿金额
            // 
            this.住宿金额.DataPropertyName = "Money";
            this.住宿金额.HeaderText = "住宿金额";
            this.住宿金额.MinimumWidth = 10;
            this.住宿金额.Name = "住宿金额";
            this.住宿金额.Width = 80;
            // 
            // 扣款
            // 
            this.扣款.DataPropertyName = "Deduction";
            this.扣款.HeaderText = "扣款";
            this.扣款.MinimumWidth = 10;
            this.扣款.Name = "扣款";
            this.扣款.Width = 80;
            // 
            // StayoutListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1730, 1254);
            this.Controls.Add(this.StaffStaffStayOutList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StayoutListFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退宿扣款";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StayoutListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffStaffStayOutList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel LbSYY;
        private System.Windows.Forms.LinkLabel LbXYY;
        private System.Windows.Forms.LinkLabel LbWY;
        private System.Windows.Forms.DataGridView StaffStaffStayOutList;
        private System.Windows.Forms.LinkLabel LbSY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.DateTimePicker dpZZTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpQSTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一级部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 二级部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住宿日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 退宿日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住宿金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 扣款;
    }
}