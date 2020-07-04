using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using OncoCalculatorCS.Classes;
using OncoCalculatorCS.Forms;
using System.Drawing.Printing;
using System.Web;
using System.Xml;
using System.Text;

namespace OncoCalculatorCS
{
    public partial class MainForm : Form
    {
        private const int TOP_FIELD = 60;
        private const int LEFT_FIELD = 60;

        private BindingList<Drug> drugs;
        private BindingList<Scheme> schemes;
        private BindingList<Patient> patients;

        private int selectedSchemeIndex;
        private int selectedDrugIndex;
        internal Scheme currentScheme;
        internal Patient currentPatient;
        private int height;
        private int age;
        private int weight;
        private int creatinin;
        private uint doseReduction = 0;
        private double BSA = 0d; // Body Surface Area
        private double GFR = 0d; // Glomerular Filtration Rate
        internal bool currentPatientNotSavedFlag { get; set; }

        public MainForm()
        {
            InitializeComponent();
            drugs = new BindingList<Drug>();
            schemes = new BindingList<Scheme>();
            patients = new BindingList<Patient>();
            currentScheme = new Scheme();
            currentPatient = new Patient();
            currentPatientNotSavedFlag = true;

            patientBTN.BackgroundImageLayout = ImageLayout.Stretch;

            {
                XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Drug>));

                try
                {
                    FileStream fs = new FileStream("drugs.xml", FileMode.OpenOrCreate);
                    drugs = formatter.Deserialize(fs) as BindingList<Drug>;
                    fs.Close();
                }
                catch
                {
                    MessageBox.Show("Cannot open Drugs File");
                }
            }

            {
                XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Scheme>));

                try
                {
                    FileStream fs = new FileStream("schemes.xml", FileMode.OpenOrCreate);
                    schemes = formatter.Deserialize(fs) as BindingList<Scheme>;
                    fs.Close();
                }
                catch
                {
                    MessageBox.Show("Cannot open Schemes File");
                }
            }

            {
                XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Patient>));

                try
                {
                    FileStream fs = new FileStream("patients.xml", FileMode.OpenOrCreate);
                    patients = formatter.Deserialize(fs) as BindingList<Patient>;
                    fs.Close();
                }
                catch
                {
                    MessageBox.Show("Cannot open Patients File");
                }
            }


            {
                drugsDataGridView.DataSource = drugs;

                drugsDataGridView.Columns["currentDose"].Visible = false;
                drugsDataGridView.Columns["name"].HeaderText = "Название";
                drugsDataGridView.Columns["description"].HeaderText = "Описание";
                drugsDataGridView.Columns["calculationMethod"].HeaderText = "Способ расчета";
                drugsDataGridView.Columns["dose"].HeaderText = "Дозировка";

                schemesDataGridView.DataSource = schemes;

                schemesDataGridView.Columns["name"].HeaderText = "Название";
                schemesDataGridView.Columns["intervalInDays"].HeaderText = "Интервал";
                schemesDataGridView.ReadOnly = true;
                schemesDataGridView.AllowUserToResizeColumns = false;

                schemeCMBX.DataSource = schemes;
                schemeCMBX.DisplayMember = "name";

                currentPatientSchemeGridView.DataSource = currentScheme.drugsList;

                currentPatientSchemeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                currentPatientSchemeGridView.Columns["calculationMethod"].Visible = false;
                currentPatientSchemeGridView.Columns["currentDose"].DefaultCellStyle.Format = "N2";
            }
        }

        private void addDrugButton_Click(object sender, EventArgs e)
        {
            drugs.Add(new Drug());
            EditDrug editDrug = new EditDrug(drugs.Last());
            editDrug.ShowDialog(this);

        }

        private void drugsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDrug editDrug = new EditDrug(drugs[(sender as DataGridView).CurrentRow.Index]);
            editDrug.ShowDialog(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Drug>));
                try
                {
                    FileStream fs = new FileStream("drugs.xml", FileMode.Create);
                    formatter.Serialize(fs, drugs);
                    fs.Close();
                }
                catch
                {
                    MessageBox.Show("Cannot open Drugs File");
                }
            }

            {
                XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Scheme>));
                try
                {
                    FileStream fs = new FileStream("schemes.xml", FileMode.Create);
                    formatter.Serialize(fs, schemes);
                    fs.Close();
                }
                catch
                {
                    MessageBox.Show("Cannot open Schemes File");
                }
            }

            {
                XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Patient>));
                try
                {
                    FileStream fs = new FileStream("patients.xml", FileMode.Create);
                    formatter.Serialize(fs, patients);
                    fs.Close();
                }
                catch
                {
                    MessageBox.Show("Cannot open Patients File");
                }
            }

        }

        private void schemesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).CurrentRow.Index < schemes.Count && 
                (sender as DataGridView).CurrentRow !=null)
            {
                
                    EditScheme editScheme = new EditScheme(schemes[(sender as DataGridView).CurrentRow.Index], drugs);
                    editScheme.ShowDialog(this);
               
            }
        }

        private void addScheme_Click(object sender, EventArgs e)
        {
            schemes.Add(new Scheme());
            EditScheme editScheme = new EditScheme(schemes.Last(), drugs);
            editScheme.ShowDialog(this);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            schemeCMBX.DataSource = schemes;
            schemeCMBX.DisplayMember = "name";

            this.schemeCMBX.Refresh();
            this.schemesDataGridView.Refresh();
            this.drugsDataGridView.Refresh();
        }

        private void schemesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSchemeIndex = schemesDataGridView.CurrentRow.Index;
        }

        private void drugsDataGridView_Click(object sender, EventArgs e)
        {
            selectedDrugIndex = drugsDataGridView.CurrentRow.Index;
        }

        private void deleteSchemeBTN(object sender, EventArgs e)
        {
            if(MessageBox.Show("Удалить схему?", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            if (selectedSchemeIndex < schemes.Count()) schemes.RemoveAt(selectedSchemeIndex);
        }

        private void drugDeleteBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить препарат?", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                if (selectedDrugIndex < drugs.Count()) drugs.RemoveAt(selectedDrugIndex);
        }

        private void schemeCMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentScheme = (schemeCMBX.SelectedItem as Scheme).clone();

            currentPatientSchemeGridView.DataSource = currentScheme.drugsList;
            currentPatientSchemeGridView.Columns["name"].HeaderText = "Название";
            currentPatientSchemeGridView.Columns["description"].HeaderText = "Описание";
            currentPatientSchemeGridView.Columns["dose"].HeaderText = "Дозировка";
            currentPatientSchemeGridView.Columns["currentDose"].HeaderText = "Доза";

            

            currentPatientSchemeGridView.Refresh();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            calculateBSA();
            calculateGFR();
            recalculateDoses();
            currentPatientSchemeGridView.Refresh();

            currentPatientSchemeGridView.ClearSelection();

            PrintDocument docToPrint = new PrintDocument();

            

            docToPrint.PrintPage += DocToPrint_PrintPage;

            printPreviewDialog.Document = docToPrint;
            (printPreviewDialog as Form).StartPosition = FormStartPosition.CenterScreen;
            (printPreviewDialog as Form).Size = new Size(800, 600);

            DialogResult result = printPreviewDialog.ShowDialog();

        }

        private void DocToPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font header_font = new Font("Times New Roman", 12, FontStyle.Regular))
            {


                StringBuilder headerString = 
                    new StringBuilder("Расчет дозы химиотерапии по схеме: " +
                                      currentScheme.name);
                if (doseReduction > 0) headerString.Append(" (редукция дозы " + doseReduction + "%)");
                headerString.Append("\n");
                
                headerString.Append ("ФИО пациента: " + nameTBX.Text + "\n \n");

                headerString.Append("Дата: " + dateTimePicker1.Value.ToShortDateString() + "\n \n");


                if (height > 0) headerString.Append("Рост(см):  " + height + "\t");
                if (weight > 0) headerString.Append("Вес(кг):  " + weight + "\t");
                if (age > 0) headerString.Append("Возраст(лет):  " + age + "\t");

                headerString.Append("\n");

                if (creatinin > 0) headerString.Append("Креатинин(мкмоль/л):  " + creatinin + "\t");
                
                headerString.Append("\n \n");

                if (BSA > 0) headerString.Append("Площадь поверхности тела (BSA)(м2):  " + BSA.ToString("0.##") + "\n \n");
                if (GFR > 0) headerString.Append("Скорость клубочковой фильтрации(СКФ)(мл/мин):  " + GFR.ToString("0.##") + "\n \n");


                foreach (Drug drug in currentScheme.drugsList)
                {
                    //TODO drug dose to printer
                    switch (drug.calculationMethod)
                    {
                        case Drug.CalculationMethod.BSA:
                            headerString.Append(drug.name + "  Доза на м2 = " + drug.dose.ToString("N2") + "мг. Доза равна = " 
                                + drug.dose.ToString("N2") + " * " + BSA.ToString("N2") + " = " + drug.currentDose.ToString("N2") + "мг");
                            break;

                        case Drug.CalculationMethod.AUC:
                            headerString.Append(drug.name + "  Доза равна = "
                                + drug.dose.ToString("N0") + " * (" + GFR.ToString("N2") + " + 25) = " + drug.currentDose.ToString("N2") + "мг");
                            break;

                        case Drug.CalculationMethod.PER_KG:
                            headerString.Append(drug.name + " Доза на кг = " + drug.dose.ToString("N2") + "мг. Доза равна = "
                                + drug.dose.ToString("N2") + " * " + weight.ToString("N2") + " = " + drug.currentDose.ToString("N2") + "мг");
                            break;

                        case Drug.CalculationMethod.FIXED:
                            headerString.Append(drug.name + "  Доза равна = " + drug.currentDose.ToString("N2") + "мг");
                            break;
                    }

                    if (doseReduction > 0)
                        headerString.Append(" - " + doseReduction.ToString() + "% = " +
                                            (drug.currentDose - (drug.currentDose * doseReduction / 100)).ToString("N2") + "мг.");

                    headerString.Append("\n");

                }

                headerString.Append("\n \t Подпись врача:");

                e.Graphics.DrawString(headerString.ToString(), header_font, new SolidBrush(Color.Black), new Point(LEFT_FIELD, TOP_FIELD));
            }


            /* 
             
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            System.Drawing.Imaging.ImageCodecInfo codec = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()[1];

            System.Drawing.Imaging.EncoderParameters eParams = new System.Drawing.Imaging.EncoderParameters(1);

            eParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);


            Bitmap bmp = new Bitmap((currentPatientSchemeGridView.Size.Width) * 4, 
                                    (currentPatientSchemeGridView.Size.Height) * 4);
            
            currentPatientSchemeGridView.DrawToBitmap(bmp, new Rectangle(0, 0,
                                                      currentPatientSchemeGridView.Width * 5,
                                                      currentPatientSchemeGridView.Height * 5));
            e.Graphics.DrawImage(bmp, 15, 120);
            */

        }

        private void heightTBX_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.heightTBX.Text, out height))
            {
                this.heightTBX.BackColor = Color.White;
                calculateBSA();

                
            }
            else
            {
                MessageBox.Show("Недопустимое значение роста");
                this.heightTBX.BackColor = Color.LightCoral;

            }
        }

        private void ageTBX_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.ageTBX.Text, out age))
            {
                this.ageTBX.BackColor = Color.White;
                calculateBSA();
                calculateGFR();
                
            }
            else
            {
                MessageBox.Show("Недопустимое значение возраста");
                this.ageTBX.BackColor = Color.LightCoral;

            }
        }

        private void weightTBX_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.weightTBX.Text, out weight))
            {
                this.weightTBX.BackColor = Color.White;
                calculateBSA();
                calculateGFR();
                
            }
            else
            {
                MessageBox.Show("Недопустимое значение веса");
                this.weightTBX.BackColor = Color.LightCoral;

            }
        }

        private void calculateBSA()
        {
            if (height > 0 && weight > 0)
            {
                BSA = Math.Sqrt(Convert.ToDouble(weight * height)/3600);
                if (BSA > 2.0D) BSA = 2.0D; 

                recalculateDoses();
            }

        }

        private void calculateGFR()
        {
            if (age > 0 && weight > 0 && creatinin > 0)
            {
                if (genderCMBX.SelectedIndex == 0) {
                    GFR = (1.25D * (Convert.ToDouble(140 - age)
                           * Convert.ToDouble(weight)) / Convert.ToDouble(creatinin));
                }

                if (genderCMBX.SelectedIndex == 1)
                {
                    GFR = (1.05D * (Convert.ToDouble(140 - age)
                           * Convert.ToDouble(weight)) / Convert.ToDouble(creatinin));
                }

                recalculateDoses();
            }
        }



        private void creatininTBX_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.creatininTBX.Text, out creatinin))
            {
                this.creatininTBX.BackColor = Color.White;
                calculateGFR();
            }
            else
            {
                MessageBox.Show("Недопустимое значение креатинина");
                this.creatininTBX.BackColor = Color.LightCoral;

            }

            calculateGFR();
        }

        private void genderCMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateGFR();
            
        }

        private void recalculateDoses()
        {
            
            foreach (Drug drug in currentScheme.drugsList)
            {
                if (drug.calculationMethod == Drug.CalculationMethod.FIXED)
                {
                    drug.currentDose = drug.dose;
                    continue;
                }

                if (drug.calculationMethod == Drug.CalculationMethod.BSA)
                {
                    if (BSA < 2)
                        drug.currentDose = drug.dose * BSA;
                    else
                        drug.currentDose = drug.dose * 2;

                }

                if (drug.calculationMethod == Drug.CalculationMethod.AUC)
                {
                    drug.currentDose = drug.dose * (GFR + 25);
                }

                if (drug.calculationMethod == Drug.CalculationMethod.PER_KG)
                {
                    drug.currentDose = drug.dose * weight;
                }
            }

            currentPatientSchemeGridView.Refresh();
        }

        private void currentPatientSchemeGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            recalculateDoses();
        }

        private void doseReductionTBX_Leave(object sender, EventArgs e)
        {
            if (UInt32.TryParse(this.doseReductionTBX.Text, out doseReduction))
            {
                this.doseReductionTBX.BackColor = Color.White;
                recalculateDoses();
                
            }
            else
            {
                MessageBox.Show("Недопустимое значение редукции дозы");
                this.doseReductionTBX.BackColor = Color.LightCoral;

            }
            if (doseReduction > 100) doseReduction = 100;
            doseReductionTBX.Text = doseReduction.ToString();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сбросить данные", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                currentPatient = new Patient();
                this.clearForm();
                this.displayPatient(currentPatient);
                currentPatientNotSavedFlag = true;
            }


        }

        private void clearForm()
        {
            nameTBX.Text = "";
            weightTBX.Text = "0";
            heightTBX.Text = "0";
            creatininTBX.Text = "0";
            ageTBX.Text = "0";
            genderCMBX.ResetText();
        }

        internal void displayPatient(Patient patient)
        {

            nameTBX.Text = currentPatient.name;

            weightTBX.Text = currentPatient.weight.ToString();
            weight = currentPatient.weight;

            heightTBX.Text = currentPatient.height.ToString();
            height = currentPatient.height;

            ageTBX.Text = currentPatient.age.ToString();
            age = currentPatient.age;

            doseReductionTBX.Text = currentPatient.doseReduction.ToString();
            doseReduction = Convert.ToUInt32(currentPatient.doseReduction);

            if (currentPatient.gender == Patient.Gender.M) genderCMBX.SelectedIndex = 0;
            if (currentPatient.gender == Patient.Gender.F) genderCMBX.SelectedIndex = 1;
            currentPatientSchemeGridView.DataSource = currentScheme.drugsList;
            currentPatientSchemeGridView.Show();
            if (currentPatient.scheme != null)
            {
                currentPatientSchemeGridView.Columns["name"].HeaderText = "Название";
                currentPatientSchemeGridView.Columns["description"].HeaderText = "Описание";
                currentPatientSchemeGridView.Columns["dose"].HeaderText = "Дозировка";
                currentPatientSchemeGridView.Columns["currentDose"].HeaderText = "Доза";
            }

        }

        private void patientBTN_Click(object sender, EventArgs e)
        {
            EditPatients editPatients = new EditPatients(patients, this);
            editPatients.ShowDialog();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            currentPatient.name = nameTBX.Text;
           
            currentPatient.height = height;
            currentPatient.age = age;
            currentPatient.weight = weight;
            currentPatient.doseReduction = Convert.ToInt32(doseReduction);
            if (genderCMBX.SelectedIndex == 0) currentPatient.gender = Patient.Gender.M;
            if (genderCMBX.SelectedIndex == 1) currentPatient.gender = Patient.Gender.F;
            currentPatient.scheme = currentScheme.clone();


            if (currentPatientNotSavedFlag) patients.Add(currentPatient);
        }

        private void nameTBX_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
