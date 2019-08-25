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
    public partial class EditDrug : Form
    {
        Drug currentDrug;
        public EditDrug(Drug currentDrug): base()
        {
            InitializeComponent();
            this.currentDrug = currentDrug;
            this.nameTBX.Text = currentDrug.name;
            this.dosageTBX.Text = currentDrug.dose.ToString();
            this.descriptionTBX.Text = currentDrug.description;
            this.Text = currentDrug.name;
            switch (currentDrug.calculationMethod)
            {
                case Drug.CalculationMethod.AUC:
                    AUC_RBTN.Checked = true;
                    break;

                case Drug.CalculationMethod.BSA:
                    BSA_RBTN.Checked = true;
                    break;

                case Drug.CalculationMethod.PER_KG:
                    PER_KG_RBTN.Checked = true;
                    break;

                case Drug.CalculationMethod.FIXED:
                    FIXED_RBTN.Checked = true;
                    break;
            }

        }

        private void EditDrug_Load(object sender, EventArgs e)
        {

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            this.currentDrug.name = this.nameTBX.Text;
            this.currentDrug.description = this.descriptionTBX.Text;
            double dose = 0;
            bool validFlag = true;

            if (Double.TryParse(this.dosageTBX.Text, out dose))
                {
                    currentDrug.dose = dose;
                    this.dosageTBX.BackColor = Color.White;
                }
            else
                {
                    MessageBox.Show("Недопустимое значение дозы");
                    this.dosageTBX.BackColor = Color.LightCoral;
                    validFlag = false;
                }

            if (BSA_RBTN.Checked) currentDrug.calculationMethod = Drug.CalculationMethod.BSA;
            if (AUC_RBTN.Checked) currentDrug.calculationMethod = Drug.CalculationMethod.AUC;
            if (PER_KG_RBTN.Checked) currentDrug.calculationMethod = Drug.CalculationMethod.PER_KG;
            if (FIXED_RBTN.Checked) currentDrug.calculationMethod = Drug.CalculationMethod.FIXED;



            this.Owner.Refresh();
            if (validFlag) this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
