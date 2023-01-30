namespace DormitoryManagement.UI.DormitoryFrm
{
    partial class UpdDormitoryFrm
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
            this.rbtnJY = new System.Windows.Forms.RadioButton();
            this.rbtnQY = new System.Windows.Forms.RadioButton();
            this.txtDormitoryNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnNv = new System.Windows.Forms.RadioButton();
            this.rbtnNan = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(470, 467);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(114, 49);
            this.butReset.TabIndex = 13;
            this.butReset.Text = "取消";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(203, 467);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(119, 49);
            this.butSave.TabIndex = 12;
            this.butSave.Text = "保存";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // rbtnJY
            // 
            this.rbtnJY.AutoSize = true;
            this.rbtnJY.Location = new System.Drawing.Point(563, 282);
            this.rbtnJY.Name = "rbtnJY";
            this.rbtnJY.Size = new System.Drawing.Size(89, 28);
            this.rbtnJY.TabIndex = 11;
            this.rbtnJY.TabStop = true;
            this.rbtnJY.Text = "禁用";
            this.rbtnJY.UseVisualStyleBackColor = true;
            // 
            // rbtnQY
            // 
            this.rbtnQY.AutoSize = true;
            this.rbtnQY.Location = new System.Drawing.Point(322, 284);
            this.rbtnQY.Name = "rbtnQY";
            this.rbtnQY.Size = new System.Drawing.Size(89, 28);
            this.rbtnQY.TabIndex = 10;
            this.rbtnQY.TabStop = true;
            this.rbtnQY.Text = "启用";
            this.rbtnQY.UseVisualStyleBackColor = true;
            // 
            // txtDormitoryNo
            // 
            this.txtDormitoryNo.Location = new System.Drawing.Point(322, 115);
            this.txtDormitoryNo.Name = "txtDormitoryNo";
            this.txtDormitoryNo.Size = new System.Drawing.Size(330, 35);
            this.txtDormitoryNo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "是否启用：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "宿舍号：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnNv);
            this.panel2.Controls.Add(this.rbtnNan);
            this.panel2.Location = new System.Drawing.Point(322, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 43);
            this.panel2.TabIndex = 15;
            // 
            // rbtnNv
            // 
            this.rbtnNv.AutoSize = true;
            this.rbtnNv.Location = new System.Drawing.Point(213, 12);
            this.rbtnNv.Name = "rbtnNv";
            this.rbtnNv.Size = new System.Drawing.Size(89, 28);
            this.rbtnNv.TabIndex = 1;
            this.rbtnNv.TabStop = true;
            this.rbtnNv.Text = "女寝";
            this.rbtnNv.UseVisualStyleBackColor = true;
            // 
            // rbtnNan
            // 
            this.rbtnNan.AutoSize = true;
            this.rbtnNan.Location = new System.Drawing.Point(3, 12);
            this.rbtnNan.Name = "rbtnNan";
            this.rbtnNan.Size = new System.Drawing.Size(89, 28);
            this.rbtnNan.TabIndex = 0;
            this.rbtnNan.TabStop = true;
            this.rbtnNan.Text = "男寝";
            this.rbtnNan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "宿舍类型：";
            // 
            // UpdDormitoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.rbtnJY);
            this.Controls.Add(this.rbtnQY);
            this.Controls.Add(this.txtDormitoryNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdDormitoryFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑宿舍";
            this.Load += new System.EventHandler(this.UpdDormitoryFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.RadioButton rbtnJY;
        private System.Windows.Forms.RadioButton rbtnQY;
        private System.Windows.Forms.TextBox txtDormitoryNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnNv;
        private System.Windows.Forms.RadioButton rbtnNan;
        private System.Windows.Forms.Label label3;
    }
}