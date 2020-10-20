using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            GasCalculation gas = new GasCalculation(double.Parse(txtBHP.Text), double.Parse(txtSW.Text), double.Parse(txtRecFactor.Text),
                double.Parse(txtAcres.Text), double.Parse(txtNetH.Text), double.Parse(txtAvgPor.Text), double.Parse(txtBblMillion.Text),
                double.Parse(txtDepth.Text), int.Parse(txtWells.Text));


            double porFeet = gas.calcPorFeet(double.Parse(txtNetH.Text), double.Parse(txtAvgPor.Text));
            double mmcfPorFeet = gas.calcMMCF_PORFT(double.Parse(txtAcres.Text), double.Parse(txtSW.Text), double.Parse(txtBHP.Text), double.Parse(txtRecFactor.Text));

            // per well
            double txtResPerMMCFF = gas.calcPerWellMMCF(porFeet, mmcfPorFeet);
            txtResPerMMCF.Text = txtResPerMMCFF.ToString();

            double txtResPerBO2 = gas.calcPerWellBO(double.Parse(txtBblMillion.Text), txtResPerMMCFF);
            txtResPerBO.Text = txtResPerBO2.ToString();


        }
    }
}
