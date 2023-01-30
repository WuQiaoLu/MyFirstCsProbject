namespace DormitoryManagement.UI.BunkFrm
{
    partial class BunkListFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BunkList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿舍号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.床位号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否启用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编辑 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BunkList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 100);
            this.panel1.TabIndex = 0;
            // 
            // BunkList
            // 
            this.BunkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BunkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.宿舍号,
            this.床位号,
            this.是否启用,
            this.编辑,
            this.删除});
            this.BunkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BunkList.Location = new System.Drawing.Point(0, 100);
            this.BunkList.Name = "BunkList";
            this.BunkList.RowHeadersWidth = 82;
            this.BunkList.RowTemplate.Height = 37;
            this.BunkList.Size = new System.Drawing.Size(1487, 1180);
            this.BunkList.TabIndex = 1;
            this.BunkList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BunkList_CellContentClick);
            this.BunkList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BunkList_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "床位信息";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(710, 23);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(120, 52);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "添加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 200;
            // 
            // 宿舍号
            // 
            this.宿舍号.DataPropertyName = "DormitoryNo";
            this.宿舍号.HeaderText = "宿舍号";
            this.宿舍号.MinimumWidth = 10;
            this.宿舍号.Name = "宿舍号";
            this.宿舍号.Width = 200;
            // 
            // 床位号
            // 
            this.床位号.DataPropertyName = "BunkNo";
            this.床位号.HeaderText = "床位号";
            this.床位号.MinimumWidth = 10;
            this.床位号.Name = "床位号";
            this.床位号.Width = 200;
            // 
            // 是否启用
            // 
            this.是否启用.DataPropertyName = "IsEnable";
            this.是否启用.HeaderText = "是否启用";
            this.是否启用.MinimumWidth = 10;
            this.是否启用.Name = "是否启用";
            this.是否启用.Width = 200;
            // 
            // 编辑
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.NullValue = "编辑";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Blue;
            this.编辑.DefaultCellStyle = dataGridViewCellStyle9;
            this.编辑.HeaderText = "";
            this.编辑.MinimumWidth = 10;
            this.编辑.Name = "编辑";
            this.编辑.Width = 200;
            // 
            // 删除
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.NullValue = "删除";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            this.删除.DefaultCellStyle = dataGridViewCellStyle10;
            this.删除.HeaderText = "";
            this.删除.MinimumWidth = 10;
            this.删除.Name = "删除";
            this.删除.Width = 200;
            // 
            // BunkListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1487, 1280);
            this.Controls.Add(this.BunkList);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BunkListFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "床位维护";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BunkListFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BunkList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BunkList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 床位号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否启用;
        private System.Windows.Forms.DataGridViewButtonColumn 编辑;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}