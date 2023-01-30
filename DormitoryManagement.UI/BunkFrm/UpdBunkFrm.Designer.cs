namespace DormitoryManagement.UI.BunkFrm
{
    partial class UpdBunkFrm
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
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.rbtnJY = new System.Windows.Forms.RadioButton();
            this.rbtnQY = new System.Windows.Forms.RadioButton();
            this.txtBunkNo = new System.Windows.Forms.TextBox();
            this.cboxDormitoryId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(491, 479);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(163, 59);
            this.butCancel.TabIndex = 17;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(257, 479);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(163, 59);
            this.butSave.TabIndex = 16;
            this.butSave.Text = "保存";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // rbtnJY
            // 
            this.rbtnJY.AutoSize = true;
            this.rbtnJY.Location = new System.Drawing.Point(565, 363);
            this.rbtnJY.Name = "rbtnJY";
            this.rbtnJY.Size = new System.Drawing.Size(89, 28);
            this.rbtnJY.TabIndex = 15;
            this.rbtnJY.TabStop = true;
            this.rbtnJY.Text = "禁用";
            this.rbtnJY.UseVisualStyleBackColor = true;
            // 
            // rbtnQY
            // 
            this.rbtnQY.AutoSize = true;
            this.rbtnQY.Location = new System.Drawing.Point(351, 367);
            this.rbtnQY.Name = "rbtnQY";
            this.rbtnQY.Size = new System.Drawing.Size(89, 28);
            this.rbtnQY.TabIndex = 14;
            this.rbtnQY.TabStop = true;
            this.rbtnQY.Text = "启用";
            this.rbtnQY.UseVisualStyleBackColor = true;
            // 
            // txtBunkNo
            // 
            this.txtBunkNo.Location = new System.Drawing.Point(351, 257);
            this.txtBunkNo.Name = "txtBunkNo";
            this.txtBunkNo.Size = new System.Drawing.Size(303, 35);
            this.txtBunkNo.TabIndex = 13;
            // 
            // cboxDormitoryId
            // 
            this.cboxDormitoryId.FormattingEnabled = true;
            this.cboxDormitoryId.Location = new System.Drawing.Point(351, 118);
            this.cboxDormitoryId.Name = "cboxDormitoryId";
            this.cboxDormitoryId.Size = new System.Drawing.Size(303, 32);
            this.cboxDormitoryId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "床位号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "是否启用：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "宿舍名称：";
            // 
            // UpdBunkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 763);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.rbtnJY);
            this.Controls.Add(this.rbtnQY);
            this.Controls.Add(this.txtBunkNo);
            this.Controls.Add(this.cboxDormitoryId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdBunkFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑床位";
            this.Load += new System.EventHandler(this.UpdBunkFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.RadioButton rbtnJY;
        private System.Windows.Forms.RadioButton rbtnQY;
        private System.Windows.Forms.TextBox txtBunkNo;
        private System.Windows.Forms.ComboBox cboxDormitoryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}