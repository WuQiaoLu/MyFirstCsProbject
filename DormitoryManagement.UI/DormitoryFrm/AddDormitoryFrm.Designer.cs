namespace DormitoryManagement.UI.DormitoryFrm
{
    partial class AddDormitoryFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDormitoryNo = new System.Windows.Forms.TextBox();
            this.rbtnQY = new System.Windows.Forms.RadioButton();
            this.rbtnJY = new System.Windows.Forms.RadioButton();
            this.butAdd = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnNv = new System.Windows.Forms.RadioButton();
            this.rbtnNan = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "是否启用：";
            // 
            // txtDormitoryNo
            // 
            this.txtDormitoryNo.Location = new System.Drawing.Point(285, 76);
            this.txtDormitoryNo.Name = "txtDormitoryNo";
            this.txtDormitoryNo.Size = new System.Drawing.Size(330, 35);
            this.txtDormitoryNo.TabIndex = 2;
            // 
            // rbtnQY
            // 
            this.rbtnQY.AutoSize = true;
            this.rbtnQY.Location = new System.Drawing.Point(15, 17);
            this.rbtnQY.Name = "rbtnQY";
            this.rbtnQY.Size = new System.Drawing.Size(89, 28);
            this.rbtnQY.TabIndex = 3;
            this.rbtnQY.TabStop = true;
            this.rbtnQY.Text = "启用";
            this.rbtnQY.UseVisualStyleBackColor = true;
            // 
            // rbtnJY
            // 
            this.rbtnJY.AutoSize = true;
            this.rbtnJY.Location = new System.Drawing.Point(220, 17);
            this.rbtnJY.Name = "rbtnJY";
            this.rbtnJY.Size = new System.Drawing.Size(89, 28);
            this.rbtnJY.TabIndex = 4;
            this.rbtnJY.TabStop = true;
            this.rbtnJY.Text = "禁用";
            this.rbtnJY.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(166, 428);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(119, 49);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "添加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(433, 428);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(114, 49);
            this.butReset.TabIndex = 6;
            this.butReset.Text = "取消";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "宿舍类型：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnNv);
            this.panel2.Controls.Add(this.rbtnNan);
            this.panel2.Location = new System.Drawing.Point(285, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 63);
            this.panel2.TabIndex = 9;
            // 
            // rbtnNv
            // 
            this.rbtnNv.AutoSize = true;
            this.rbtnNv.Location = new System.Drawing.Point(220, 26);
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
            this.rbtnNan.Location = new System.Drawing.Point(24, 26);
            this.rbtnNan.Name = "rbtnNan";
            this.rbtnNan.Size = new System.Drawing.Size(89, 28);
            this.rbtnNan.TabIndex = 0;
            this.rbtnNan.TabStop = true;
            this.rbtnNan.Text = "男寝";
            this.rbtnNan.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnQY);
            this.panel1.Controls.Add(this.rbtnJY);
            this.panel1.Location = new System.Drawing.Point(285, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 64);
            this.panel1.TabIndex = 10;
            // 
            // AddDormitoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(825, 804);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtDormitoryNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDormitoryFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加宿舍";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDormitoryNo;
        private System.Windows.Forms.RadioButton rbtnQY;
        private System.Windows.Forms.RadioButton rbtnJY;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnNv;
        private System.Windows.Forms.RadioButton rbtnNan;
        private System.Windows.Forms.Panel panel1;
    }
}