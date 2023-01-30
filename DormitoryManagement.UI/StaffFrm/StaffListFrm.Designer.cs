namespace DormitoryManagement.UI.StaffFrm
{
    partial class StaffListFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butAdd = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.一级部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.二级部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手机号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否启用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.详情 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.编辑 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butAdd);
            this.panel1.Controls.Add(this.butSelect);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 100);
            this.panel1.TabIndex = 0;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(683, 29);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(122, 42);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "添加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(501, 29);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(122, 42);
            this.butSelect.TabIndex = 2;
            this.butSelect.Text = "查询";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 35);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // StaffList
            // 
            this.StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.姓名,
            this.性别,
            this.类别,
            this.工号,
            this.一级部门,
            this.二级部门,
            this.手机号,
            this.是否启用,
            this.详情,
            this.编辑,
            this.删除});
            this.StaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffList.Location = new System.Drawing.Point(0, 100);
            this.StaffList.Name = "StaffList";
            this.StaffList.RowHeadersWidth = 82;
            this.StaffList.RowTemplate.Height = 37;
            this.StaffList.Size = new System.Drawing.Size(1488, 1169);
            this.StaffList.TabIndex = 1;
            this.StaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffList_CellContentClick);
            this.StaffList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StaffList_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel4);
            this.panel2.Controls.Add(this.linkLabel3);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.labelFenYe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1488, 100);
            this.panel2.TabIndex = 2;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(1009, 47);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(82, 24);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "上一页";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(1107, 47);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(82, 24);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "下一页";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(1207, 47);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(58, 24);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "尾页";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(925, 47);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "首页";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelFenYe
            // 
            this.labelFenYe.AutoSize = true;
            this.labelFenYe.Location = new System.Drawing.Point(115, 47);
            this.labelFenYe.Name = "labelFenYe";
            this.labelFenYe.Size = new System.Drawing.Size(586, 24);
            this.labelFenYe.TabIndex = 0;
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
            // 手机号
            // 
            this.手机号.DataPropertyName = "Mobile";
            this.手机号.HeaderText = "手机号";
            this.手机号.MinimumWidth = 10;
            this.手机号.Name = "手机号";
            // 
            // 是否启用
            // 
            this.是否启用.DataPropertyName = "IsEnable";
            this.是否启用.HeaderText = "是否启用";
            this.是否启用.MinimumWidth = 10;
            this.是否启用.Name = "是否启用";
            this.是否启用.Width = 80;
            // 
            // 详情
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.NullValue = "详情";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.详情.DefaultCellStyle = dataGridViewCellStyle1;
            this.详情.HeaderText = "";
            this.详情.MinimumWidth = 10;
            this.详情.Name = "详情";
            this.详情.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.详情.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.详情.Width = 80;
            // 
            // 编辑
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.NullValue = "编辑";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.编辑.DefaultCellStyle = dataGridViewCellStyle2;
            this.编辑.HeaderText = "";
            this.编辑.MinimumWidth = 10;
            this.编辑.Name = "编辑";
            this.编辑.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.编辑.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.编辑.Width = 80;
            // 
            // 删除
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = "删除";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.删除.DefaultCellStyle = dataGridViewCellStyle3;
            this.删除.HeaderText = "";
            this.删除.MinimumWidth = 10;
            this.删除.Name = "删除";
            this.删除.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.删除.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.删除.Width = 80;
            // 
            // StaffListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1488, 1269);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StaffList);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffListFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工维护";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffListFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StaffList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFenYe;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一级部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 二级部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手机号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否启用;
        private System.Windows.Forms.DataGridViewButtonColumn 详情;
        private System.Windows.Forms.DataGridViewButtonColumn 编辑;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}