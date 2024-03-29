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
    public partial class EditPatients : Form
    {
        private BindingList<Patient> patients;
        private BindingList<Patient> filteredPatients;
        MainForm mainForm = null;

        public EditPatients(ref BindingList<Patient> patients, MainForm mainForm)
        {
            InitializeComponent();
                     
            List<Patient> sortedList = patients.OrderBy(x => x.name).ToList();
            patients = new BindingList<Patient>(sortedList);

            this.patients = patients;
            this.mainForm = mainForm;
            this.filteredPatients = this.patients;


            patientsDataGridView.ReadOnly = true;
            patientsDataGridView.DataSource = this.filteredPatients;
            patientsDataGridView.Columns["name"].HeaderText = "ФИО";
            patientsDataGridView.Columns["description"].HeaderText = "Описание";
            patientsDataGridView.Columns["scheme"].HeaderText = "Схема";
            patientsDataGridView.Columns["name"].Width = 200;
            patientsDataGridView.Columns["weight"].Visible = false;
            patientsDataGridView.Columns["height"].Visible = false;
            patientsDataGridView.Columns["age"].Visible = false;
            patientsDataGridView.Columns["doseReduction"].Visible = false;
            patientsDataGridView.Columns["gender"].Visible = false;

            
        }

        private void patientsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mainForm.currentPatient = filteredPatients[(sender as DataGridView).CurrentRow.Index];
            mainForm.currentScheme = filteredPatients[(sender as DataGridView).CurrentRow.Index].scheme;
            mainForm.schemeNameTBX.Text = filteredPatients[(sender as DataGridView).CurrentRow.Index].scheme.ToString();
            mainForm.currentPatientNotSavedFlag = false;
            mainForm.displayPatient(mainForm.currentPatient);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in patientsDataGridView.SelectedRows)
            {
                patientsDataGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void searchTBX_TextChanged(object sender, EventArgs e)
        {
            List<Patient> sortedList = this.patients.Where(x => x.name.StartsWith((searchTBX.Text.ToString()),StringComparison.InvariantCultureIgnoreCase)).ToList();

            this.filteredPatients = new BindingList<Patient>(sortedList); 

            patientsDataGridView.ReadOnly = true;
            patientsDataGridView.DataSource = this.filteredPatients;
            patientsDataGridView.Columns["name"].HeaderText = "ФИО";
            patientsDataGridView.Columns["description"].HeaderText = "Описание";
            patientsDataGridView.Columns["scheme"].HeaderText = "Схема";
            patientsDataGridView.Columns["name"].Width = 200;
            patientsDataGridView.Columns["weight"].Visible = false;
            patientsDataGridView.Columns["height"].Visible = false;
            patientsDataGridView.Columns["age"].Visible = false;
            patientsDataGridView.Columns["doseReduction"].Visible = false;
            patientsDataGridView.Columns["gender"].Visible = false;
            patientsDataGridView.Refresh();
        }
    }
}
