namespace DormitoryManagement.UI.DormitoryDetailDTOFrm
{
    partial class DormitorystatisticsFrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TotalBormitorys = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.宿舍统计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总床位数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住总人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.剩余人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本周入住 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本周退宿 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TotalBormitorys)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalBormitorys
            // 
            this.TotalBormitorys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalBormitorys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.宿舍统计,
            this.总床位数,
            this.入住总人数,
            this.剩余人,
            this.本周入住,
            this.本周退宿});
            this.TotalBormitorys.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalBormitorys.Location = new System.Drawing.Point(0, 0);
            this.TotalBormitorys.Name = "TotalBormitorys";
            this.TotalBormitorys.RowHeadersWidth = 82;
            this.TotalBormitorys.RowTemplate.Height = 37;
            this.TotalBormitorys.Size = new System.Drawing.Size(1603, 718);
            this.TotalBormitorys.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 718);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1603, 565);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 565);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(838, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 565);
            this.panel3.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(959, 565);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(765, 565);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // 宿舍统计
            // 
            this.宿舍统计.DataPropertyName = "dormitory";
            this.宿舍统计.HeaderText = "宿舍统计";
            this.宿舍统计.MinimumWidth = 10;
            this.宿舍统计.Name = "宿舍统计";
            this.宿舍统计.Width = 200;
            // 
            // 总床位数
            // 
            this.总床位数.DataPropertyName = "bed";
            this.总床位数.HeaderText = "总床位数";
            this.总床位数.MinimumWidth = 10;
            this.总床位数.Name = "总床位数";
            this.总床位数.Width = 200;
            // 
            // 入住总人数
            // 
            this.入住总人数.DataPropertyName = "Checkin";
            this.入住总人数.HeaderText = "入住总人数（人）";
            this.入住总人数.MinimumWidth = 10;
            this.入住总人数.Name = "入住总人数";
            this.入住总人数.Width = 200;
            // 
            // 剩余人
            // 
            this.剩余人.DataPropertyName = "surplus";
            this.剩余人.HeaderText = "剩余（人）";
            this.剩余人.MinimumWidth = 10;
            this.剩余人.Name = "剩余人";
            this.剩余人.Width = 200;
            // 
            // 本周入住
            // 
            this.本周入住.DataPropertyName = "weekCheck";
            this.本周入住.HeaderText = "本周入住（人）";
            this.本周入住.MinimumWidth = 10;
            this.本周入住.Name = "本周入住";
            this.本周入住.Width = 200;
            // 
            // 本周退宿
            // 
            this.本周退宿.DataPropertyName = "Stayout";
            this.本周退宿.HeaderText = "本周退宿（人）";
            this.本周退宿.MinimumWidth = 10;
            this.本周退宿.Name = "本周退宿";
            this.本周退宿.Width = 200;
            // 
            // DormitorystatisticsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1603, 1283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TotalBormitorys);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DormitorystatisticsFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汇总统计";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DormitorystatisticsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalBormitorys)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TotalBormitorys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍统计;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总床位数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入住总人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 剩余人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本周入住;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本周退宿;
    }
}