namespace DormitoryManagement.UI.StationInfo
{
    partial class StationUpdFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.CboxParentId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(487, 508);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(154, 63);
            this.butReset.TabIndex = 17;
            this.butReset.Text = "重置";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(207, 508);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(154, 63);
            this.butSave.TabIndex = 16;
            this.butSave.Text = "保存";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(456, 338);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(65, 28);
            this.rbtnNo.TabIndex = 15;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "否";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(296, 338);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(65, 28);
            this.rbtnYes.TabIndex = 14;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "是";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "是否启用：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "部门名称：";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(296, 230);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(345, 35);
            this.txtSecondName.TabIndex = 11;
            // 
            // CboxParentId
            // 
            this.CboxParentId.FormattingEnabled = true;
            this.CboxParentId.Location = new System.Drawing.Point(296, 137);
            this.CboxParentId.Name = "CboxParentId";
            this.CboxParentId.Size = new System.Drawing.Size(338, 32);
            this.CboxParentId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "一级部门：";
            // 
            // StationUpdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(838, 790);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.rbtnYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.CboxParentId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StationUpdFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑二级部门数据";
            this.Load += new System.EventHandler(this.StationUpdFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.ComboBox CboxParentId;
        private System.Windows.Forms.Label label1;
    }
}