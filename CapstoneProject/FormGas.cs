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

                txtMMCF_PortFt.Text = MMCF_PorFt.ToString();
                txtPorFeet.Text = porFeet.ToString();
                txtMWE.Text = MWE.ToString();


                // per well

                double txtResPerMMCFF = gas.calcPerWellMMCF(porFeet, MMCF_PorFt);
                txtResPerMMCF.Text = txtResPerMMCFF.ToString();

                double txtResPerBO2 = gas.calcPerWellBO(double.Parse(txtBblMillion.Text), txtResPerMMCFF, txtResPerMMCFF);
                txtResPerBO.Text = txtResPerBO2.ToString();


                //total res
                double TtlResMMCF = gas.calcTotalResMMCF(txtResPerMMCFF, int.Parse(txtWells.Text));
                txtTtlResMMCF.Text = TtlResMMCF.ToString();

                double ttlResBO = gas.calcTotalResBO(txtResPerBO2, int.Parse(txtWells.Text));
                txtTtlResBO.Text = ttlResBO.ToString();
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

        }

        private void lblSW_Click(object sender, EventArgs e)
        {

        }

        private void lblRecFactor_Click(object sender, EventArgs e)
        {

        }
    }
}
