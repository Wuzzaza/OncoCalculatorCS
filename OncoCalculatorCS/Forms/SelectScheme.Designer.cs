namespace OncoCalculatorCS.Forms
{
    partial class SelectScheme
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
            this.schemeDataGridView = new System.Windows.Forms.DataGridView();
            this.searchSchemeTBX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.schemeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // schemeDataGridView
            // 
            this.schemeDataGridView.AllowUserToAddRows = false;
            this.schemeDataGridView.AllowUserToDeleteRows = false;
            this.schemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schemeDataGridView.Location = new System.Drawing.Point(12, 54);
            this.schemeDataGridView.Name = "schemeDataGridView";
            this.schemeDataGridView.Size = new System.Drawing.Size(560, 495);
            this.schemeDataGridView.TabIndex = 0;
            this.schemeDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schemeDataGridView_CellContentDoubleClick);
            // 
            // searchSchemeTBX
            // 
            this.searchSchemeTBX.Location = new System.Drawing.Point(12, 12);
            this.searchSchemeTBX.Name = "searchSchemeTBX";
            this.searchSchemeTBX.Size = new System.Drawing.Size(560, 20);
            this.searchSchemeTBX.TabIndex = 1;
            this.searchSchemeTBX.TextChanged += new System.EventHandler(this.searchSchemeTBX_TextChanged);
            // 
            // SelectScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.searchSchemeTBX);
            this.Controls.Add(this.schemeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectScheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите схему";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.schemeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView schemeDataGridView;
        private System.Windows.Forms.TextBox searchSchemeTBX;
    }
}