namespace DormitoryManagement.UI.StaffStayOutFrm
{
    partial class StaffStayOutListFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lsbSYY = new System.Windows.Forms.LinkLabel();
            this.lsbXYY = new System.Windows.Forms.LinkLabel();
            this.labWY = new System.Windows.Forms.LinkLabel();
            this.labSY = new System.Windows.Forms.LinkLabel();
            this.labelFenYe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butSelect = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffStayOutList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一级部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.二级部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否签订宿舍安全协议 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否开通门禁 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.退宿时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.扣款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否楼长 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿舍 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.床位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编辑 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffStayOutList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbSYY
            // 
            this.lsbSYY.AutoSize = true;
            this.lsbSYY.Location = new System.Drawing.Point(1225, 38);
            this.lsbSYY.Name = "lsbSYY";
            this.lsbSYY.Size = new System.Drawing.Size(82, 24);
            this.lsbSYY.TabIndex = 9;
            this.lsbSYY.TabStop = true;
            this.lsbSYY.Text = "上一页";
            this.lsbSYY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lsbSYY_LinkClicked);
            // 
            // lsbXYY
            // 
            this.lsbXYY.AutoSize = true;
            this.lsbXYY.Location = new System.Drawing.Point(1323, 38);
            this.lsbXYY.Name = "lsbXYY";
            this.lsbXYY.Size = new System.Drawing.Size(82, 24);
            this.lsbXYY.TabIndex = 8;
            this.lsbXYY.TabStop = true;
            this.lsbXYY.Text = "下一页";
            this.lsbXYY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lsbXYY_LinkClicked);
            // 
            // labWY
            // 
            this.labWY.AutoSize = true;
            this.labWY.Location = new System.Drawing.Point(1423, 38);
            this.labWY.Name = "labWY";
            this.labWY.Size = new System.Drawing.Size(58, 24);
            this.labWY.TabIndex = 7;
            this.labWY.TabStop = true;
            this.labWY.Text = "尾页";
            this.labWY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labWY_LinkClicked);
            // 
            // labSY
            // 
            this.labSY.AutoSize = true;
            this.labSY.Location = new System.Drawing.Point(1141, 38);
            this.labSY.Name = "labSY";
            this.labSY.Size = new System.Drawing.Size(58, 24);
            this.labSY.TabIndex = 6;
            this.labSY.TabStop = true;
            this.labSY.Text = "首页";
            this.labSY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labSY_LinkClicked);
            // 
            // labelFenYe
            // 
            this.labelFenYe.AutoSize = true;
            this.labelFenYe.Location = new System.Drawing.Point(331, 38);
            this.labelFenYe.Name = "labelFenYe";
            this.labelFenYe.Size = new System.Drawing.Size(586, 24);
            this.labelFenYe.TabIndex = 5;
            this.labelFenYe.Text = "共 N 条数据，每页显示 N 条，共 N 页，当前第 N 页";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsbSYY);
            this.panel2.Controls.Add(this.lsbXYY);
            this.panel2.Controls.Add(this.labWY);
            this.panel2.Controls.Add(this.labSY);
            this.panel2.Controls.Add(this.labelFenYe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1716, 100);
            this.panel2.TabIndex = 4;
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(561, 31);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(125, 49);
            this.butSelect.TabIndex = 3;
            this.butSelect.Text = "查询";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(920, 31);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(125, 49);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "添加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 35);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名：";
            // 
            // StaffStayOutList
            // 
            this.StaffStayOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffStayOutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.姓名,
            this.性别,
            this.类别,
            this.工号,
            this.一级部门,
            this.二级部门,
            this.是否签订宿舍安全协议,
            this.是否开通门禁,
            this.入住时间,
            this.退宿时间,
            this.扣款金额,
            this.是否楼长,
            this.宿舍,
            this.床位,
            this.编辑,
            this.删除});
            this.StaffStayOutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffStayOutList.Location = new System.Drawing.Point(0, 100);
            this.StaffStayOutList.Name = "StaffStayOutList";
            this.StaffStayOutList.RowHeadersWidth = 82;
            this.StaffStayOutList.RowTemplate.Height = 37;
            this.StaffStayOutList.Size = new System.Drawing.Size(1716, 1199);
            this.StaffStayOutList.TabIndex = 5;
            this.StaffStayOutList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffStayOutList_CellContentClick);
            this.StaffStayOutList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StaffCheckInList_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butSelect);
            this.panel1.Controls.Add(this.butAdd);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1716, 100);
            this.panel1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 50;
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
            // 工号
            // 
            this.工号.DataPropertyName = "EmpNo";
            this.工号.HeaderText = "工号";
            this.工号.MinimumWidth = 10;
            this.工号.Name = "工号";
            this.工号.Width = 80;
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
            // 是否签订宿舍安全协议
            // 
            this.是否签订宿舍安全协议.DataPropertyName = "Treaty";
            this.是否签订宿舍安全协议.HeaderText = "是否签订宿舍安全协议";
            this.是否签订宿舍安全协议.MinimumWidth = 10;
            this.是否签订宿舍安全协议.Name = "是否签订宿舍安全协议";
            this.是否签订宿舍安全协议.Width = 80;
            // 
            // 是否开通门禁
            // 
            this.是否开通门禁.DataPropertyName = "Access";
            this.是否开通门禁.HeaderText = "是否开通门禁";
            this.是否开通门禁.MinimumWidth = 10;
            this.是否开通门禁.Name = "是否开通门禁";
            this.是否开通门禁.Width = 80;
            // 
            // 入住时间
            // 
            this.入住时间.DataPropertyName = "CheckInTime";
            this.入住时间.HeaderText = "入住时间";
            this.入住时间.MinimumWidth = 10;
            this.入住时间.Name = "入住时间";
            this.入住时间.Width = 80;
            // 
            // 退宿时间
            // 
            this.退宿时间.DataPropertyName = "StayOutTime";
            this.退宿时间.HeaderText = "退宿时间";
            this.退宿时间.MinimumWidth = 10;
            this.退宿时间.Name = "退宿时间";
            this.退宿时间.Width = 80;
            // 
            // 扣款金额
            // 
            this.扣款金额.DataPropertyName = "Deduction";
            this.扣款金额.HeaderText = "扣款金额";
            this.扣款金额.MinimumWidth = 10;
            this.扣款金额.Name = "扣款金额";
            this.扣款金额.Width = 80;
            // 
            // 是否楼长
            // 
            this.是否楼长.DataPropertyName = "TowerParent";
            this.是否楼长.HeaderText = "是否楼长";
            this.是否楼长.MinimumWidth = 10;
            this.是否楼长.Name = "是否楼长";
            this.是否楼长.Width = 80;
            // 
            // 宿舍
            // 
            this.宿舍.DataPropertyName = "DormitoryNo";
            this.宿舍.HeaderText = "宿舍";
            this.宿舍.MinimumWidth = 10;
            this.宿舍.Name = "宿舍";
            this.宿舍.Width = 80;
            // 
            // 床位
            // 
            this.床位.DataPropertyName = "BunkNo";
            this.床位.HeaderText = "床位";
            this.床位.MinimumWidth = 10;
            this.床位.Name = "床位";
            this.床位.Width = 80;
            // 
            // 编辑
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.NullValue = "编辑";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.编辑.DefaultCellStyle = dataGridViewCellStyle1;
            this.编辑.HeaderText = "";
            this.编辑.MinimumWidth = 10;
            this.编辑.Name = "编辑";
            this.编辑.Width = 60;
            // 
            // 删除
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "删除";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.删除.DefaultCellStyle = dataGridViewCellStyle2;
            this.删除.HeaderText = "";
            this.删除.MinimumWidth = 10;
            this.删除.Name = "删除";
            this.删除.Width = 60;
            // 
            // StaffStayOutListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1716, 1299);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StaffStayOutList);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffStayOutListFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工退宿列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffStayOutListFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffStayOutList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lsbSYY;
        private System.Windows.Forms.LinkLabel lsbXYY;
        private System.Windows.Forms.LinkLabel labWY;
        private System.Windows.Forms.LinkLabel labSY;
        private System.Windows.Forms.Label labelFenYe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StaffStayOutList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一级部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 二级部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否签订宿舍安全协议;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否开通门禁;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入住时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 退宿时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 扣款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否楼长;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍;
        private System.Windows.Forms.DataGridViewTextBoxColumn 床位;
        private System.Windows.Forms.DataGridViewButtonColumn 编辑;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}