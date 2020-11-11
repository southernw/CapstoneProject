using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class FormOil : Form
    {
        public FormOil()
        {
            InitializeComponent();
        }

        private void FormOil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {

                        errorProvider1.SetError(txtBox, "Field can not be empty");
                        txtBox.Focus();

                    }
                    else
                        errorProvider1.SetError(txtBox, "");
                }
            }
            try {
            
                OilCalculation oil = new OilCalculation(double.Parse(txtThickness.Text), double.Parse(txtPorosity.Text), double.Parse(txtWaterSat.Text), double.Parse(txtArea.Text), double.Parse(txtRecFactor.Text));

                double porFeet = oil.calcPorFeet(double.Parse(txtThickness.Text), double.Parse(txtPorosity.Text));

                txtResPorFeet.Text = porFeet.ToString("N", new CultureInfo("en-US"));

                double bblPerAcre = oil.calcBblPerAcre(porFeet, double.Parse(txtWaterSat.Text));
                txtResBblAcre.Text = bblPerAcre.ToString("N", new CultureInfo("en-US"));

                double bblOoip = oil.calcBblPerOoip(bblPerAcre, oil.getArea());
                txtResBblOoip.Text = bblOoip.ToString("N", new CultureInfo("en-US"));

                double bblRecov = oil.calcBblRecov(bblOoip, double.Parse(txtRecFactor.Text));
                txtResRecov.Text = bblRecov.ToString("N", new CultureInfo("en-US"));

                double boEq = oil.calcBoEq(bblRecov, double.Parse(txtArea.Text), double.Parse(txtThickness.Text));
                txtResBoAcrFt.Text = boEq.ToString("N", new CultureInfo("en-US"));

            }catch (Exception ex)
            {
                double result;
                foreach (Control control in groupBox1.Controls)
                {
                    string controlType = control.GetType().ToString();
                    if (controlType == "System.Windows.Forms.TextBox")
                    {
                        TextBox txtBox = (TextBox)control;
                        if (!double.TryParse(txtBox.Text, out result))
                        {

                            errorProvider1.SetError(txtBox, "Field in incorrect format");
                            txtBox.Focus();

                        }
                    }
                }
            }
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtResBblAcre.Text == "")
            {

                MessageBox.Show("No output to save. Please try again!", "Error Saving", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            try
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save Results";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                        string test = "Porosity Feet: " + txtResPorFeet.Text.ToString() + "\n" +
                                      "Bbl Per Acre: " + txtResBblAcre.Text.ToString() + "\n" +
                                      "Bbl Original Oil in Place: " + txtResBblOoip.Text.ToString() + "\n" +
                                      "Bbl Recoverable: " + txtResRecov.Text.ToString() + "\n" +
                                      "Barrels/Acre Ft. Equivalent: " + txtResBoAcrFt.Text.ToString();

                    string fileName = saveFileDialog1.FileName;
                    File.WriteAllText(fileName, test);
                    
                }
            }
            catch (IOException ex)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtArea.Text = "";
            txtPorosity.Text = "";
            txtRecFactor.Text = "";
            txtThickness.Text = "";
            txtWaterSat.Text = "";
        }
    }
}
