namespace OncoCalculatorCS.Forms
{
    partial class EditScheme
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
            this.currentSchemeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalTBX = new System.Windows.Forms.TextBox();
            this.drugsGridView = new System.Windows.Forms.DataGridView();
            this.saveBTN = new System.Windows.Forms.Button();
            this.removeDrugBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentSchemeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // currentSchemeDataGridView
            // 
            this.currentSchemeDataGridView.AllowUserToAddRows = false;
            this.currentSchemeDataGridView.AllowUserToDeleteRows = false;
            this.currentSchemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentSchemeDataGridView.Location = new System.Drawing.Point(16, 97);
            this.currentSchemeDataGridView.Name = "currentSchemeDataGridView";
            this.currentSchemeDataGridView.Size = new System.Drawing.Size(366, 300);
            this.currentSchemeDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Схема";
            // 
            // nameTBX
            // 
            this.nameTBX.Location = new System.Drawing.Point(75, 13);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(100, 20);
            this.nameTBX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Интервал";
            // 
            // intervalTBX
            // 
            this.intervalTBX.Location = new System.Drawing.Point(75, 39);
            this.intervalTBX.Name = "intervalTBX";
            this.intervalTBX.Size = new System.Drawing.Size(100, 20);
            this.intervalTBX.TabIndex = 2;
            // 
            // drugsGridView
            // 
            this.drugsGridView.AllowUserToAddRows = false;
            this.drugsGridView.AllowUserToDeleteRows = false;
            this.drugsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugsGridView.Location = new System.Drawing.Point(388, 97);
            this.drugsGridView.Name = "drugsGridView";
            this.drugsGridView.ReadOnly = true;
            this.drugsGridView.Size = new System.Drawing.Size(400, 300);
            this.drugsGridView.TabIndex = 0;
            this.drugsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drugsGridView_CellDoubleClick);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(13, 415);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 3;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // removeDrugBTN
            // 
            this.removeDrugBTN.Location = new System.Drawing.Point(307, 415);
            this.removeDrugBTN.Name = "removeDrugBTN";
            this.removeDrugBTN.Size = new System.Drawing.Size(75, 23);
            this.removeDrugBTN.TabIndex = 5;
            this.removeDrugBTN.Text = "Удалить";
            this.removeDrugBTN.UseVisualStyleBackColor = true;
            this.removeDrugBTN.Click += new System.EventHandler(this.removeDrugBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Препараты схемы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Добавить препарат";
            // 
            // EditScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeDrugBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.intervalTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTBX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drugsGridView);
            this.Controls.Add(this.currentSchemeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditScheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditScheme";
            ((System.ComponentModel.ISupportInitialize)(this.currentSchemeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView currentSchemeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox intervalTBX;
        private System.Windows.Forms.DataGridView drugsGridView;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button removeDrugBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}