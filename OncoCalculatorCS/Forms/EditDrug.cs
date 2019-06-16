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
            this.dosageTBX.Text = currentDrug.doseBSA.ToString();
            this.descriptionTBX.Text = currentDrug.description;
            this.AUCTBX.Text = currentDrug.AUC.ToString();
            this.Text = currentDrug.name;
            this.constantDoseCBX.Checked = currentDrug.constantDose;

        }

        private void EditDrug_Load(object sender, EventArgs e)
        {

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            this.currentDrug.name = this.nameTBX.Text;
            this.currentDrug.description = this.descriptionTBX.Text;
            int doseBSA = 0;
            int AUC = 0;
            bool validFlag = true;

            if (Int32.TryParse(this.dosageTBX.Text, out doseBSA))
                {
                    currentDrug.doseBSA = doseBSA;
                    this.dosageTBX.BackColor = Color.White;
                }
            else
                {
                    MessageBox.Show("Недопустимое значение дозы");
                    this.dosageTBX.BackColor = Color.LightCoral;
                    validFlag = false;
                }


            if (Int32.TryParse(this.AUCTBX.Text, out AUC))
                {
                    currentDrug.AUC = AUC;
                    this.AUCTBX.BackColor = Color.White;
                }
            else
                {
                    MessageBox.Show("Недопустимое значение AUC");
                    this.AUCTBX.BackColor = Color.LightCoral;
                    validFlag = false;
                }

            currentDrug.constantDose = this.constantDoseCBX.Checked;

            this.Owner.Refresh();
            if (validFlag) this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
