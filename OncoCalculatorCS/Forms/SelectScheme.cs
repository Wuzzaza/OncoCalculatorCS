using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OncoCalculatorCS.Classes;


namespace OncoCalculatorCS.Forms
{
    public partial class SelectScheme : Form
    {

        private BindingList<Scheme> schemes;
        private BindingList<Scheme> filteredSchemes;
        private Scheme currentScheme;
        private MainForm mainForm = null;

        public SelectScheme(ref BindingList<Classes.Scheme> schemes, ref Scheme currentScheme, MainForm mainForm)
        {
            InitializeComponent();
            this.schemes = schemes;
            this.mainForm = mainForm;
            this.currentScheme = currentScheme;
            this.filteredSchemes = this.schemes;

            List<Scheme> sortedList = schemes.OrderBy(x => x.name).ToList();
            schemes = new BindingList<Scheme>(sortedList);

            schemeDataGridView.ReadOnly = true;
            schemeDataGridView.DataSource = this.filteredSchemes;

        }

        private void searchSchemeTBX_TextChanged(object sender, EventArgs e)
        {
            
            List<Scheme> sortedList = this.schemes.Where(x => x.name.ToLower().Contains((searchSchemeTBX.Text.ToString()).ToLower())).ToList();
            this.filteredSchemes = new BindingList<Scheme>(sortedList);

            schemeDataGridView.ReadOnly = true;
            schemeDataGridView.DataSource = this.filteredSchemes;
        }

        private void schemeDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mainForm.currentPatient.scheme = filteredSchemes[(sender as DataGridView).CurrentRow.Index].clone();
            mainForm.currentScheme = mainForm.currentPatient.scheme;
            mainForm.schemeNameTBX.Text = mainForm.currentScheme.ToString();
            mainForm.displayPatient(mainForm.currentPatient);
            this.Close();
        }
    }
}
