namespace OncoCalculatorCS.Forms
{
    partial class EditPatients
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
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AllowUserToAddRows = false;
            this.patientsDataGridView.AllowUserToResizeColumns = false;
            this.patientsDataGridView.AllowUserToResizeRows = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(3, 58);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.Size = new System.Drawing.Size(580, 500);
            this.patientsDataGridView.TabIndex = 0;
            this.patientsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список Пациентов";
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button button1;
    }
}