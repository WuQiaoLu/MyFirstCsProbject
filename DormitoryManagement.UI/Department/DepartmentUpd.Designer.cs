namespace DormitoryManagement.UI.BasicInfo
{
    partial class DepartmentUpd
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
            this.butReset = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStairName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(447, 310);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(157, 54);
            this.butReset.TabIndex = 13;
            this.butReset.Text = "取消";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(230, 310);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(157, 54);
            this.butSave.TabIndex = 12;
            this.butSave.Text = "保存";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(478, 196);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(65, 28);
            this.rbtnNo.TabIndex = 11;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "否";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(336, 196);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(65, 28);
            this.rbtnYes.TabIndex = 10;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "是";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "是否启用：";
            // 
            // txtStairName
            // 
            this.txtStairName.Location = new System.Drawing.Point(345, 86);
            this.txtStairName.Name = "txtStairName";
            this.txtStairName.Size = new System.Drawing.Size(295, 35);
            this.txtStairName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "一级部门名称：";
            // 
            // DepartmentUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.rbtnYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStairName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentUpd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑一级部门";
            this.Load += new System.EventHandler(this.DepartmentUpd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStairName;
        private System.Windows.Forms.Label label1;
    }
}