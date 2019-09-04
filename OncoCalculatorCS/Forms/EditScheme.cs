using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OncoCalculatorCS.Classes;

namespace OncoCalculatorCS.Forms
{
    public partial class EditScheme : Form
    {
        Scheme scheme;
        BindingList<Drug> drugs;

        public EditScheme(Scheme scheme, BindingList<Drug> drugs)
        {

            InitializeComponent();
            this.scheme = scheme;
            this.drugs = drugs;

            this.Text = scheme.name;

            drugsGridView.DataSource = drugs;
            drugsGridView.ReadOnly = true;
            drugsGridView.Columns["currentDose"].Visible = false;
            //drugsGridView.Columns["calculationMethod"].Visible = false;
                        drugsGridView.Columns["name"].HeaderText = "Название";
            drugsGridView.Columns["description"].HeaderText = "Описание";
            drugsGridView.Columns["dose"].Width = 80;
            drugsGridView.Columns["dose"].HeaderText = "Дозировка";
            drugsGridView.AllowUserToResizeColumns = false;

            currentSchemeDataGridView.DataSource = scheme.drugsList;
            currentSchemeDataGridView.Columns["currentDose"].Visible = false;
            //currentSchemeDataGridView.Columns["calculationMethod"].Visible = false;
            currentSchemeDataGridView.Columns["name"].HeaderText = "Название";
            currentSchemeDataGridView.Columns["description"].HeaderText = "Описание";
            currentSchemeDataGridView.Columns["dose"].Width = 80;
            currentSchemeDataGridView.Columns["dose"].HeaderText = "Дозировка";
            currentSchemeDataGridView.AllowUserToResizeColumns = false;


            nameTBX.Text = scheme.name;
            intervalTBX.Text = scheme.intervalInDays.ToString();

        }

        private void drugsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Drug newDrug = drugs[(sender as DataGridView).CurrentRow.Index].clone();
            this.scheme.drugsList.Add(newDrug);
            currentSchemeDataGridView.Refresh();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            this.scheme.name = nameTBX.Text;

            int interval = 0;
            bool validFlag = true;

            if (Int32.TryParse(this.intervalTBX.Text, out interval))
            {
                scheme.intervalInDays = interval;
                this.intervalTBX.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Недопустимый интервал");
                this.intervalTBX.BackColor = Color.LightCoral;
                validFlag = false;
            }

            this.Owner.Refresh();
            if (validFlag) this.Close();

        }

        
       

        private void removeDrugBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.currentSchemeDataGridView.SelectedRows)
            {
                currentSchemeDataGridView.Rows.RemoveAt(item.Index);
            }
        }
    }
}
