﻿using System;
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
        int selectedRow;

        public EditScheme(Scheme scheme, BindingList<Drug> drugs)
        {

            InitializeComponent();
            this.scheme = scheme;
            this.drugs = drugs;

            drugsGridView.DataSource = drugs;
            drugsGridView.ReadOnly = true;
            drugsGridView.Columns["currentDose"].Visible = false;
            drugsGridView.Columns["name"].HeaderText = "Название";
            drugsGridView.Columns["description"].HeaderText = "Описание";
            drugsGridView.Columns["doseBSA"].Width = 50;
            drugsGridView.Columns["doseBSA"].HeaderText = "Доза на м2";
            drugsGridView.Columns["AUC"].Width = 50;
            drugsGridView.AllowUserToResizeColumns = false;

            currentSchemeDataGridView.DataSource = scheme.drugsList;
            currentSchemeDataGridView.Columns["currentDose"].Visible = false;
            currentSchemeDataGridView.Columns["name"].HeaderText = "Название";
            currentSchemeDataGridView.Columns["description"].HeaderText = "Описание";
            currentSchemeDataGridView.Columns["doseBSA"].Width = 50;
            currentSchemeDataGridView.Columns["doseBSA"].HeaderText = "Доза на м2";
            currentSchemeDataGridView.Columns["AUC"].Width = 50;
            currentSchemeDataGridView.AllowUserToResizeColumns = false;


            nameTBX.Text = scheme.name;
            intervalTBX.Text = scheme.intervalInDays.ToString();

        }

        private void drugsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Drug newDrug = drugs[(sender as DataGridView).CurrentRow.Index].Copy();
            this.scheme.drugsList.Add(newDrug);
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

        private void currentSchemeDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
        }

        private void currentSchemeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = currentSchemeDataGridView.CurrentRow.Index;
        }

        private void removeDrugBTN_Click(object sender, EventArgs e)
        {
            if (selectedRow < scheme.drugsList.Count) scheme.drugsList.RemoveAt(selectedRow);

        }
    }
}
