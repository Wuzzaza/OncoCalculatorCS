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
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AllowUserToAddRows = false;
            this.patientsDataGridView.AllowUserToDeleteRows = false;
            this.patientsDataGridView.AllowUserToResizeColumns = false;
            this.patientsDataGridView.AllowUserToResizeRows = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.Size = new System.Drawing.Size(600, 600);
            this.patientsDataGridView.TabIndex = 0;
            this.patientsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellDoubleClick);
            // 
            // EditPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
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
    }
}