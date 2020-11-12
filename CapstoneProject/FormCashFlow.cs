using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using System.IO;

namespace CapstoneProject
{
    public partial class FormCashFlow : Form
    {
        public FormCashFlow()
        {
            InitializeComponent();

        }

    

        private void FormCashFlow_Load(object sender, EventArgs e)
         {
            button2.Enabled = false;
            button3.Enabled = false;
            CashFlow cash = new CashFlow();
            cash.modf(dataGridView1);
            
         }

 

        private void button1_Click(object sender, EventArgs e)
        {


            CashFlow cash = new CashFlow();

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

            //double cashFlow = cash.gas_rate(8);
            //textBox1.Text = cashFlow.ToString();

            // int months = 119;
            //double BPM = 10.00;
            // double OIL_ESCL = 0.04;
            //double OIL_PRICE = 42.00;

            
                try
                {
                    double AParam = double.Parse(txtAParam.Text);
                    double BParam = double.Parse(txtBParam.Text);
                    double GasPrice = double.Parse(txtGasPrice.Text);
                    double GasEscl = double.Parse(txtGasEscl.Text);
                    double LOEMonth = double.Parse(txtLOEMonth.Text);
                    double LOEescl = double.Parse(txtLOEEscl.Text);
                    double NRI = double.Parse(txtNRI.Text);
                    double BPM = double.Parse(txtBPM.Text);
                    double OIL_PRICE = double.Parse(txtOilPrice.Text);
                    double OIL_ESCL = double.Parse(txtOilEscalation.Text);

                if (GasEscl < 0 || GasEscl > 1 || LOEescl < 0 || LOEescl > 1 || NRI < 0 || NRI > 1 || OIL_ESCL < 0 || OIL_ESCL > 1)
                {
                    if(GasEscl < 0 || GasEscl > 1)
                        errorProvider1.SetError(txtGasEscl, "Field can not be greater than 1 or less than 0");

                    if (LOEescl < 0 || LOEescl > 1)
                        errorProvider1.SetError(txtLOEEscl, "Field can not be greater than 1 or less than 0");

                    if (NRI < 0 || NRI > 1)
                        errorProvider1.SetError(txtNRI, "Field can not be greater than 1 or less than 0");

                    if (OIL_ESCL < 0 || OIL_ESCL > 1)
                        errorProvider1.SetError(txtOilEscalation, "Field can not be greater than 1 or less than 0");

                    return;
                }
                int months = int.Parse(txtMonths.Text);

                    dataGridView1.Rows.Clear();

                    cash.addRows(dataGridView1, months);
                    cash.addGasPrice(dataGridView1, months);
                    cash.addMonth(dataGridView1, months);
                    cash.addGasRate(dataGridView1, months);
                    cash.addCumMMCF(dataGridView1, months);
                    cash.addOilRateBBLMonth(dataGridView1, months, BPM);
                    cash.addOilPrice(dataGridView1, months, OIL_ESCL, OIL_PRICE);
                    cash.addCumOil(dataGridView1, months);
                    cash.addLOE(dataGridView1, months);
                    cash.addGrossRev(dataGridView1, months);
                    cash.addNetRev(dataGridView1, months);
                    cash.addSumOfNetRev(dataGridView1, months);
                    //double gasPrice = cash.gas_price(8);
                    // textBox2.Text = gasPrice.ToString();

                    //double[] data = new double[100] = cash.gas_price(8);
                    button2.Enabled = true;
                    button3.Enabled = true;
            }
                catch (Exception ex)
                {

                    Debug.Write(ex.StackTrace);
                    foreach (Control control in groupBox1.Controls)
                    {
                        double result;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCashFlowChart form2 = new FormCashFlowChart(dataGridView1);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt";
                saveFileDialog1.Title = "Export Table Data";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    dataGridView1.SelectAll();
                    DataObject dataObject = dataGridView1.GetClipboardContent();
                    File.WriteAllText(saveFileDialog1.FileName, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                    dataGridView1.ClearSelection();
                }
            }
            catch (IOException ex)
            {

            }
        }
    }
}