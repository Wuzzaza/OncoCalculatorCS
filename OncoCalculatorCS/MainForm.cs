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
        BindingList<Drug> drugs;
        BindingList<Scheme> schemes;
        int selectedSchemeIndex;
        int selectedDrugIndex;
        Scheme currentScheme;
        int height;
        int age;
        int weight;
        int creatinin;
        double BSA = 0d;

        public MainForm()
        {
            InitializeComponent();
            drugs = new BindingList<Drug>();
            schemes = new BindingList<Scheme>();

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

                       
            drugsDataGridView.DataSource = drugs;

            drugsDataGridView.Columns["currentDose"].Visible = false;
            drugsDataGridView.Columns["name"].HeaderText = "Название";
            drugsDataGridView.Columns["description"].HeaderText = "Описание";
            drugsDataGridView.Columns["doseBSA"].HeaderText = "Доза на м2";

            schemesDataGridView.DataSource = schemes;

            schemesDataGridView.Columns["name"].HeaderText = "Название";
            schemesDataGridView.Columns["intervalInDays"].HeaderText = "Интервал";
            schemesDataGridView.ReadOnly = true;
            schemesDataGridView.AllowUserToResizeColumns = false;

            schemeCMBX.DataSource = schemes;
            schemeCMBX.DisplayMember = "name";

            currentPatientSchemeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void addDrugButton_Click(object sender, EventArgs e)
        {
            drugs.Add(new Drug());
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
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            currentPatientSchemeGridView.DataSource = (schemeCMBX.SelectedItem as Scheme).drugsList;
            currentPatientSchemeGridView.Columns["name"].HeaderText = "Название";
            currentPatientSchemeGridView.Columns["description"].HeaderText = "Описание";
            currentPatientSchemeGridView.Columns["doseBSA"].HeaderText = "Доза на м2";
            currentPatientSchemeGridView.Columns["currentDose"].HeaderText = "Доза";

            currentScheme = (schemeCMBX.SelectedItem as Scheme);

            currentPatientSchemeGridView.Refresh();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
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
                    new StringBuilder("Рассчет дозы химиотерапии по схеме: " +
                                      currentScheme.name + "\n");

                headerString.Append ("ФИО:  " + nameTBX.Text + "\n");

                if (height > 0) headerString.Append("Рост(см):  " + height + "\t");
                if (weight > 0) headerString.Append("Вес(кг):  " + weight + "\t");
                if (age > 0) headerString.Append("Возраст(лет):  " + age + "\t");

                headerString.Append("\n");

                if (height > 0 && weight >0) headerString.Append("Площадь поверхности тела (BSA)(м2):  " + BSA.ToString("0.##") + "\n");

                e.Graphics.DrawString(headerString.ToString(), header_font, new SolidBrush(Color.Black), new Point(20, 20));
            }

            Bitmap bmp = new Bitmap(currentPatientSchemeGridView.Size.Width + 10, currentPatientSchemeGridView.Size.Height + 10);
            currentPatientSchemeGridView.DrawToBitmap(bmp, new Rectangle(0, 0,
                                                      currentPatientSchemeGridView.Width + 1,
                                                      currentPatientSchemeGridView.Height));
            e.Graphics.DrawImage(bmp, 15, 120);


            
            
            
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
            }

        }
    }
}
