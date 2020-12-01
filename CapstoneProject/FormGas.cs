using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class FormGas : Form
    {
        public new System.Windows.Forms.AutoScaleMode AutoScaleMode { get; set; }
        public FormGas()
        {
            InitializeComponent();
            

           
        }


        /*
        private bool ValidateFields()
        {

        }
        */
        private void txtBHP_KeyPress(object sender, KeyPressEventArgs e)
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
            try
            {
                    GasCalculation gas = new GasCalculation(double.Parse(txtBHP.Text), double.Parse(txtSW.Text), double.Parse(txtRecFactor.Text),
                    double.Parse(txtAcres.Text), double.Parse(txtNetH.Text), double.Parse(txtAvgPor.Text), double.Parse(txtBblMillion.Text),
                    double.Parse(txtDepth.Text), int.Parse(txtWells.Text));


                double porFeet = gas.calcPorFeet(double.Parse(txtNetH.Text), double.Parse(txtAvgPor.Text));
                double MWE = gas.calcMWE(double.Parse(txtBHP.Text), double.Parse(txtDepth.Text));
                double MMCF_PorFt = gas.calcMMCF_PORFT(double.Parse(txtAcres.Text), double.Parse(txtSW.Text), double.Parse(txtBHP.Text), double.Parse(txtRecFactor.Text));

              
                txtMMCF_PortFt.Text = MMCF_PorFt.ToString("F");
                txtPorFeet.Text = porFeet.ToString("F");
                txtMWE.Text = MWE.ToString("F");


                // per well
                txtRecFactor.Enabled = true;
                txtResPerBO.Enabled = true;
                txtResPerMMCF.Enabled = true;
                txtResPerMMCF.Enabled = true;
                txtTtlResBO.Enabled = true;
                txtTtlResMMCF.Enabled = true;
                txtMWE.Enabled = true;
                txtPorFeet.Enabled = true;
                txtMMCF_PortFt.Enabled = true;

                double txtResPerMMCFF = gas.calcPerWellMMCF(porFeet, MMCF_PorFt);
                txtResPerMMCF.Text = txtResPerMMCFF.ToString("N0");

                double txtResPerBO2 = gas.calcPerWellBO(double.Parse(txtBblMillion.Text), txtResPerMMCFF, txtResPerMMCFF);
                txtResPerBO.Text = txtResPerBO2.ToString("N0");


                //total res
                double TtlResMMCF = gas.calcTotalResMMCF(txtResPerMMCFF, int.Parse(txtWells.Text));
                txtTtlResMMCF.Text = TtlResMMCF.ToString("N0");

                double ttlResBO = gas.calcTotalResBO(txtResPerBO2, int.Parse(txtWells.Text));
                txtTtlResBO.Text = ttlResBO.ToString("N0");
            }
            catch (Exception ex)
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
        private void txtBHP_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtResPerBO.Text == "")
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
                    saveFileDialog1.FileName = txtWellName.Text.ToString();
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string test =  "Well name: " + txtWellName.Text.ToString() + "\n\n" +
                                       "Inputs: \n" +
                                       "Bottom Hole Pressure (PSI): " + txtBHP.Text.ToString() + "\n" +
                                       "Salt Water Saturation (%): " + txtSW.Text.ToString() + "\n" +
                                       "Area (acres): " + txtAcres.Text.ToString() + "\n" +
                                       "Recovery Factor (%): " + txtRecFactor.Text.ToString() + "\n" +
                                       "Net Height (ft): " + txtNetH.Text.ToString() + "\n\n" +
                                       "Results: \n" +
                                       "Per Well BO: " + txtResPerBO.Text.ToString() + "\n" +
                                       "Per Well MMCF : " + txtResPerMMCF.Text.ToString() + "\n" +
                                       "Total Reserve BO: " + txtTtlResBO.Text.ToString() + "\n" +
                                       "Total Reserve MMCF " + txtTtlResMMCF.Text.ToString() + "\n" +
                                       "Porosity Feet: " + txtPorFeet.Text.ToString() + "\n" +
                                       "Mud Weight Estimated: " + txtMWE.Text.ToString() + "\n" +
                                       "MMCF/Por Ft: " + txtMMCF_PortFt.Text.ToString();

                        
                        File.WriteAllText(saveFileDialog1.FileName, test);

                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("There was an error. Please try again!", "Error Saving",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void lblSW_Click(object sender, EventArgs e)
        {

        }

        private void lblRecFactor_Click(object sender, EventArgs e)
        {

        }

      
        private void FormGas_Load(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBHP.Text = "";
            txtSW.Text = "";
            txtNetH.Text = "";
            txtDepth.Text = "";
            txtRecFactor.Text = "";
            txtAcres.Text = "";
            txtWells.Text = "";
            txtBblMillion.Text = "";
            txtAvgPor.Text = "";
        }
    }
}
