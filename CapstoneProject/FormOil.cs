using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        }
    }
}
