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
            this.label4 = new System.Windows.Forms.Label();
            this.AUCTBX = new System.Windows.Forms.TextBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.constantDoseCBX = new System.Windows.Forms.CheckBox();
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
            this.nameTBX.Location = new System.Drawing.Point(79, 13);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(219, 20);
            this.nameTBX.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Доза на м2";
            // 
            // dosageTBX
            // 
            this.dosageTBX.Location = new System.Drawing.Point(79, 39);
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
            this.descriptionTBX.Location = new System.Drawing.Point(79, 65);
            this.descriptionTBX.Name = "descriptionTBX";
            this.descriptionTBX.Size = new System.Drawing.Size(219, 20);
            this.descriptionTBX.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "AUC";
            // 
            // AUCTBX
            // 
            this.AUCTBX.Location = new System.Drawing.Point(79, 91);
            this.AUCTBX.Name = "AUCTBX";
            this.AUCTBX.Size = new System.Drawing.Size(219, 20);
            this.AUCTBX.TabIndex = 3;
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
            // constantDoseCBX
            // 
            this.constantDoseCBX.AutoSize = true;
            this.constantDoseCBX.Location = new System.Drawing.Point(79, 117);
            this.constantDoseCBX.Name = "constantDoseCBX";
            this.constantDoseCBX.Size = new System.Drawing.Size(136, 17);
            this.constantDoseCBX.TabIndex = 5;
            this.constantDoseCBX.Text = "Фиксированная доза";
            this.constantDoseCBX.UseVisualStyleBackColor = true;
            // 
            // EditDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.constantDoseCBX);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.AUCTBX);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AUCTBX;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.CheckBox constantDoseCBX;
    }
}