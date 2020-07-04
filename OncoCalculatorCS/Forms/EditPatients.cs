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
        MainForm mainForm = null;

        public EditPatients(BindingList<Patient> patients, MainForm mainForm)
        {
            this.patients = patients;
            this.mainForm = mainForm;
            InitializeComponent();

            List<Patient> sortedList = patients.OrderBy(x => x.name).ToList();
            patients = new BindingList<Patient>(sortedList);
            this.patients = new BindingList<Patient>(sortedList);

            patientsDataGridView.ReadOnly = true;
            patientsDataGridView.DataSource = patients;
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
            mainForm.currentPatient = patients[(sender as DataGridView).CurrentRow.Index];
            mainForm.currentScheme = patients[(sender as DataGridView).CurrentRow.Index].scheme;
            mainForm.currentPatientNotSavedFlag = false;
            mainForm.displayPatient(mainForm.currentPatient);
            this.Close();
        }
    }
}
