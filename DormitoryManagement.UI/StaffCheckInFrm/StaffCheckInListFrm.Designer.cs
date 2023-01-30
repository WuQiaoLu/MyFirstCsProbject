namespace DormitoryManagement.UI.StaffCheckInFrm
{
    partial class StaffCheckInListFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaffCheckInList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelFenYe = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.签订宿舍安全协议 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.门禁开通情况 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住宿金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼长 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿舍长 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编辑 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffCheckInList)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1812, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel4);
            this.panel2.Controls.Add(this.linkLabel3);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.labelFenYe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1812, 100);
            this.panel2.TabIndex = 1;
            // 
            // StaffCheckInList
            // 
            this.StaffCheckInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffCheckInList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.姓名,
            this.性别,
            this.类别,
            this.工号,
            this.签订宿舍安全协议,
            this.门禁开通情况,
            this.入住时间,
            this.住宿金额,
            this.楼长,
            this.宿舍长,
            this.编辑,
            this.删除});
            this.StaffCheckInList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffCheckInList.Location = new System.Drawing.Point(0, 100);
            this.StaffCheckInList.Name = "StaffCheckInList";
            this.StaffCheckInList.RowHeadersWidth = 82;
            this.StaffCheckInList.RowTemplate.Height = 37;
            this.StaffCheckInList.Size = new System.Drawing.Size(1812, 1024);
            this.StaffCheckInList.TabIndex = 2;
            this.StaffCheckInList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffCheckInList_CellContentClick);
            this.StaffCheckInList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StaffCheckInList_CellFormatting);
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 35);
            this.txtName.TabIndex = 1;
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
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(1225, 38);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(82, 24);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "上一页";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(1323, 38);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(82, 24);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "下一页";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(1423, 38);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(58, 24);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "尾页";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1141, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "首页";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // 签订宿舍安全协议
            // 
            this.签订宿舍安全协议.DataPropertyName = "Treaty";
            this.签订宿舍安全协议.HeaderText = "签订宿舍安全协议";
            this.签订宿舍安全协议.MinimumWidth = 10;
            this.签订宿舍安全协议.Name = "签订宿舍安全协议";
            this.签订宿舍安全协议.Width = 150;
            // 
            // 门禁开通情况
            // 
            this.门禁开通情况.DataPropertyName = "Access";
            this.门禁开通情况.HeaderText = "门禁开通情况";
            this.门禁开通情况.MinimumWidth = 10;
            this.门禁开通情况.Name = "门禁开通情况";
            this.门禁开通情况.Width = 150;
            // 
            // 入住时间
            // 
            this.入住时间.DataPropertyName = "CheckInTime";
            this.入住时间.HeaderText = "入住时间";
            this.入住时间.MinimumWidth = 10;
            this.入住时间.Name = "入住时间";
            this.入住时间.Width = 80;
            // 
            // 住宿金额
            // 
            this.住宿金额.DataPropertyName = "Money";
            this.住宿金额.HeaderText = "住宿金额";
            this.住宿金额.MinimumWidth = 10;
            this.住宿金额.Name = "住宿金额";
            this.住宿金额.Width = 80;
            // 
            // 楼长
            // 
            this.楼长.DataPropertyName = "TowerParent";
            this.楼长.HeaderText = "楼长";
            this.楼长.MinimumWidth = 10;
            this.楼长.Name = "楼长";
            this.楼长.Width = 80;
            // 
            // 宿舍长
            // 
            this.宿舍长.DataPropertyName = "DormParent";
            this.宿舍长.HeaderText = "宿舍长";
            this.宿舍长.MinimumWidth = 10;
            this.宿舍长.Name = "宿舍长";
            this.宿舍长.Width = 80;
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
            // StaffCheckInListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1812, 1224);
            this.Controls.Add(this.StaffCheckInList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffCheckInListFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工入住列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffCheckInListFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffCheckInList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView StaffCheckInList;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelFenYe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 签订宿舍安全协议;
        private System.Windows.Forms.DataGridViewTextBoxColumn 门禁开通情况;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入住时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住宿金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼长;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍长;
        private System.Windows.Forms.DataGridViewButtonColumn 编辑;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}