namespace OncoCalculatorCS.Forms
{
    partial class EditDrug
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
            this.nameTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dosageTBX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTBX = new System.Windows.Forms.TextBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FIXED_RBTN = new System.Windows.Forms.RadioButton();
            this.PER_KG_RBTN = new System.Windows.Forms.RadioButton();
            this.AUC_RBTN = new System.Windows.Forms.RadioButton();
            this.BSA_RBTN = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название ";
            // 
            // nameTBX
            // 
            this.nameTBX.Location = new System.Drawing.Point(183, 13);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(219, 20);
            this.nameTBX.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Доза (мг на м2, мг на кг, AUC)";
            // 
            // dosageTBX
            // 
            this.dosageTBX.Location = new System.Drawing.Point(183, 39);
            this.dosageTBX.Name = "dosageTBX";
            this.dosageTBX.Size = new System.Drawing.Size(219, 20);
            this.dosageTBX.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Описание";
            // 
            // descriptionTBX
            // 
            this.descriptionTBX.Location = new System.Drawing.Point(183, 65);
            this.descriptionTBX.Name = "descriptionTBX";
            this.descriptionTBX.Size = new System.Drawing.Size(219, 20);
            this.descriptionTBX.TabIndex = 2;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(16, 176);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FIXED_RBTN);
            this.groupBox1.Controls.Add(this.PER_KG_RBTN);
            this.groupBox1.Controls.Add(this.AUC_RBTN);
            this.groupBox1.Controls.Add(this.BSA_RBTN);
            this.groupBox1.Location = new System.Drawing.Point(16, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ расчета";
            // 
            // FIXED_RBTN
            // 
            this.FIXED_RBTN.AutoSize = true;
            this.FIXED_RBTN.Location = new System.Drawing.Point(167, 43);
            this.FIXED_RBTN.Name = "FIXED_RBTN";
            this.FIXED_RBTN.Size = new System.Drawing.Size(78, 17);
            this.FIXED_RBTN.TabIndex = 3;
            this.FIXED_RBTN.TabStop = true;
            this.FIXED_RBTN.Text = "фикс доза";
            this.FIXED_RBTN.UseVisualStyleBackColor = true;
            // 
            // PER_KG_RBTN
            // 
            this.PER_KG_RBTN.AutoSize = true;
            this.PER_KG_RBTN.Location = new System.Drawing.Point(167, 20);
            this.PER_KG_RBTN.Name = "PER_KG_RBTN";
            this.PER_KG_RBTN.Size = new System.Drawing.Size(67, 17);
            this.PER_KG_RBTN.TabIndex = 1;
            this.PER_KG_RBTN.TabStop = true;
            this.PER_KG_RBTN.Text = "мг на кг";
            this.PER_KG_RBTN.UseVisualStyleBackColor = true;
            // 
            // AUC_RBTN
            // 
            this.AUC_RBTN.AutoSize = true;
            this.AUC_RBTN.Location = new System.Drawing.Point(7, 43);
            this.AUC_RBTN.Name = "AUC_RBTN";
            this.AUC_RBTN.Size = new System.Drawing.Size(47, 17);
            this.AUC_RBTN.TabIndex = 2;
            this.AUC_RBTN.TabStop = true;
            this.AUC_RBTN.Text = "AUC";
            this.AUC_RBTN.UseVisualStyleBackColor = true;
            // 
            // BSA_RBTN
            // 
            this.BSA_RBTN.AutoSize = true;
            this.BSA_RBTN.Checked = true;
            this.BSA_RBTN.Location = new System.Drawing.Point(7, 20);
            this.BSA_RBTN.Name = "BSA_RBTN";
            this.BSA_RBTN.Size = new System.Drawing.Size(70, 17);
            this.BSA_RBTN.TabIndex = 0;
            this.BSA_RBTN.TabStop = true;
            this.BSA_RBTN.Text = "мг на м2";
            this.BSA_RBTN.UseVisualStyleBackColor = true;
            // 
            // EditDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 211);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.descriptionTBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dosageTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTBX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDrug";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditDrug_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dosageTBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTBX;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FIXED_RBTN;
        private System.Windows.Forms.RadioButton PER_KG_RBTN;
        private System.Windows.Forms.RadioButton AUC_RBTN;
        private System.Windows.Forms.RadioButton BSA_RBTN;
    }
}