namespace OncoCalculatorCS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.printBTN = new System.Windows.Forms.Button();
            this.currentPatientSchemeGridView = new System.Windows.Forms.DataGridView();
            this.schemeCMBX = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genderCMBX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.creatininTBX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weightTBX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ageTBX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.heightTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.addScheme = new System.Windows.Forms.Button();
            this.schemesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.drugDeleteBTN = new System.Windows.Forms.Button();
            this.addDrugButton = new System.Windows.Forms.Button();
            this.drugsDataGridView = new System.Windows.Forms.DataGridView();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPatientSchemeGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schemesDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(759, 536);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.printBTN);
            this.tabPage1.Controls.Add(this.currentPatientSchemeGridView);
            this.tabPage1.Controls.Add(this.schemeCMBX);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.genderCMBX);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.creatininTBX);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.weightTBX);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ageTBX);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.heightTBX);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nameTBX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пациент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // printBTN
            // 
            this.printBTN.Location = new System.Drawing.Point(670, 162);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(75, 23);
            this.printBTN.TabIndex = 8;
            this.printBTN.Text = "Печать";
            this.printBTN.UseVisualStyleBackColor = true;
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // currentPatientSchemeGridView
            // 
            this.currentPatientSchemeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.currentPatientSchemeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.currentPatientSchemeGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.currentPatientSchemeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPatientSchemeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.currentPatientSchemeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentPatientSchemeGridView.Location = new System.Drawing.Point(11, 191);
            this.currentPatientSchemeGridView.Name = "currentPatientSchemeGridView";
            this.currentPatientSchemeGridView.Size = new System.Drawing.Size(734, 313);
            this.currentPatientSchemeGridView.TabIndex = 7;
            // 
            // schemeCMBX
            // 
            this.schemeCMBX.FormattingEnabled = true;
            this.schemeCMBX.Location = new System.Drawing.Point(135, 164);
            this.schemeCMBX.Name = "schemeCMBX";
            this.schemeCMBX.Size = new System.Drawing.Size(248, 21);
            this.schemeCMBX.TabIndex = 6;
            this.schemeCMBX.SelectedIndexChanged += new System.EventHandler(this.schemeCMBX_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Схема ХТ";
            // 
            // genderCMBX
            // 
            this.genderCMBX.FormattingEnabled = true;
            this.genderCMBX.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.genderCMBX.Location = new System.Drawing.Point(135, 137);
            this.genderCMBX.Name = "genderCMBX";
            this.genderCMBX.Size = new System.Drawing.Size(121, 21);
            this.genderCMBX.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пол";
            // 
            // creatininTBX
            // 
            this.creatininTBX.Location = new System.Drawing.Point(135, 110);
            this.creatininTBX.Name = "creatininTBX";
            this.creatininTBX.Size = new System.Drawing.Size(248, 20);
            this.creatininTBX.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Креатинин (мкмоль/л)";
            // 
            // weightTBX
            // 
            this.weightTBX.Location = new System.Drawing.Point(135, 84);
            this.weightTBX.Name = "weightTBX";
            this.weightTBX.Size = new System.Drawing.Size(248, 20);
            this.weightTBX.TabIndex = 3;
            this.weightTBX.Text = "0";
            this.weightTBX.Leave += new System.EventHandler(this.weightTBX_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Вес (кг)";
            // 
            // ageTBX
            // 
            this.ageTBX.Location = new System.Drawing.Point(135, 58);
            this.ageTBX.Name = "ageTBX";
            this.ageTBX.Size = new System.Drawing.Size(248, 20);
            this.ageTBX.TabIndex = 2;
            this.ageTBX.Text = "0";
            this.ageTBX.Leave += new System.EventHandler(this.ageTBX_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Возраст (лет)";
            // 
            // heightTBX
            // 
            this.heightTBX.Location = new System.Drawing.Point(135, 32);
            this.heightTBX.Name = "heightTBX";
            this.heightTBX.Size = new System.Drawing.Size(248, 20);
            this.heightTBX.TabIndex = 1;
            this.heightTBX.Text = "0";
            this.heightTBX.Leave += new System.EventHandler(this.heightTBX_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Рост (см)";
            // 
            // nameTBX
            // 
            this.nameTBX.Location = new System.Drawing.Point(135, 6);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(248, 20);
            this.nameTBX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.addScheme);
            this.tabPage2.Controls.Add(this.schemesDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Схемы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить схему";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteSchemeBTN);
            // 
            // addScheme
            // 
            this.addScheme.Location = new System.Drawing.Point(6, 484);
            this.addScheme.Name = "addScheme";
            this.addScheme.Size = new System.Drawing.Size(75, 23);
            this.addScheme.TabIndex = 1;
            this.addScheme.Text = "Добавить";
            this.addScheme.UseVisualStyleBackColor = true;
            this.addScheme.Click += new System.EventHandler(this.addScheme_Click);
            // 
            // schemesDataGridView
            // 
            this.schemesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schemesDataGridView.Location = new System.Drawing.Point(5, 5);
            this.schemesDataGridView.Name = "schemesDataGridView";
            this.schemesDataGridView.ReadOnly = true;
            this.schemesDataGridView.Size = new System.Drawing.Size(740, 460);
            this.schemesDataGridView.TabIndex = 0;
            this.schemesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schemesDataGridView_CellClick);
            this.schemesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schemesDataGridView_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.drugDeleteBTN);
            this.tabPage3.Controls.Add(this.addDrugButton);
            this.tabPage3.Controls.Add(this.drugsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(751, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Препараты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // drugDeleteBTN
            // 
            this.drugDeleteBTN.Location = new System.Drawing.Point(636, 484);
            this.drugDeleteBTN.Name = "drugDeleteBTN";
            this.drugDeleteBTN.Size = new System.Drawing.Size(108, 23);
            this.drugDeleteBTN.TabIndex = 2;
            this.drugDeleteBTN.Text = "Удалить препарат";
            this.drugDeleteBTN.UseVisualStyleBackColor = true;
            this.drugDeleteBTN.Click += new System.EventHandler(this.drugDeleteBTN_Click);
            // 
            // addDrugButton
            // 
            this.addDrugButton.Location = new System.Drawing.Point(5, 484);
            this.addDrugButton.Name = "addDrugButton";
            this.addDrugButton.Size = new System.Drawing.Size(75, 23);
            this.addDrugButton.TabIndex = 1;
            this.addDrugButton.Text = "Добавить";
            this.addDrugButton.UseVisualStyleBackColor = true;
            this.addDrugButton.Click += new System.EventHandler(this.addDrugButton_Click);
            // 
            // drugsDataGridView
            // 
            this.drugsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugsDataGridView.Location = new System.Drawing.Point(5, 5);
            this.drugsDataGridView.Name = "drugsDataGridView";
            this.drugsDataGridView.ReadOnly = true;
            this.drugsDataGridView.Size = new System.Drawing.Size(740, 460);
            this.drugsDataGridView.TabIndex = 0;
            this.drugsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drugsDataGridView_CellDoubleClick);
            this.drugsDataGridView.Click += new System.EventHandler(this.drugsDataGridView_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.UseAntiAlias = true;
            this.printPreviewDialog.Visible = false;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(OncoCalculatorCS.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OncoCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPatientSchemeGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schemesDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox genderCMBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox creatininTBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageTBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heightTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox schemeCMBX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView drugsDataGridView;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.DataGridView schemesDataGridView;
        private System.Windows.Forms.Button addDrugButton;
        private System.Windows.Forms.Button addScheme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button drugDeleteBTN;
        private System.Windows.Forms.DataGridView currentPatientSchemeGridView;
        private System.Windows.Forms.Button printBTN;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.TextBox weightTBX;
        private System.Windows.Forms.Label label7;
    }
}

