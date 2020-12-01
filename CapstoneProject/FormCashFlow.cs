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
        public string str;
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

            // this.MinimumSize = new Size(800, 600);
           // this.MinimumSize = Screen.PrimaryScreen.Bounds.Size;
            //this.WindowState = FormWindowState.Maximized;
            //this.SizeGripStyle = SizeGripStyle.Hide;

            txtGasEscl.MouseHover += TextBox_MouseHover;
            txtNRI.MouseHover += TextBox_MouseHover;
            txtOilEscl.MouseHover += TextBox_MouseHover;
            txtLOEEscl.MouseHover += TextBox_MouseHover;
        }

        private void TextBox_MouseHover(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
                toolTip2.Show("Please enter percentage in decimal", textbox);
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

                if (GasEscl < 0 || GasEscl > 100 || LOEescl < 0 || LOEescl > 100 || NRI < 0 || NRI > 100 || OIL_ESCL < 0 || OIL_ESCL > 100)
                {
                    if(GasEscl < 0 || GasEscl > 1)
                        errorProvider1.SetError(txtGasEscl, "Field can not be greater than 100 or less than 0");

                    if (LOEescl < 0 || LOEescl > 1)
                        errorProvider1.SetError(txtLOEEscl, "Field can not be greater than 100 or less than 0");

                    if (NRI < 0 || NRI > 1)
                        errorProvider1.SetError(txtNRI, "Field can not be greater than 100 or less than 0");

                    if (OIL_ESCL < 0 || OIL_ESCL > 1)
                        errorProvider1.SetError(txtOilEscalation, "Field can not be greater than 100 or less than 0");

                    return;
                }
                int months = int.Parse(txtMonths.Text);
                if (months < 2)
                {
                    MessageBox.Show("Months must be greater than 1. Please try again. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    dataGridView1.Rows.Clear();

                    cash.addRows(dataGridView1, months);
                    cash.addGasPrice(dataGridView1, months, GasPrice, GasEscl);
                    cash.addMonth(dataGridView1, months);
                    cash.addGasRate(dataGridView1, months, AParam, BParam);
                    cash.addCumMMCF(dataGridView1, months, AParam);
                    cash.addOilRateBBLMonth(dataGridView1, months, BPM);
                    cash.addOilPrice(dataGridView1, months, OIL_ESCL, OIL_PRICE);
                    cash.addCumOil(dataGridView1, months);
                    cash.addLOE(dataGridView1, months, LOEMonth, LOEescl);
                    cash.addGrossRev(dataGridView1, months);
                    cash.addNetRev(dataGridView1, months, NRI);
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
            str = txtWellName.Text.ToString();
            FormCashFlowChart form2 = new FormCashFlowChart(dataGridView1, txtWellName.Text);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtWellName == null || string.IsNullOrWhiteSpace(txtWellName.Text))
            {
                errorProvider1.SetError(txtWellName, "Please set a well name");
                return;
            }
            else
            {
                errorProvider1.SetError(txtWellName, null);
            }

            try
            {
                
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt";
                saveFileDialog1.Title = "Export Table Data";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = txtWellName.Text.ToString();

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

        private void txtNRI_TextChanged(object sender, EventArgs e)
        {
            toolTip1.Show("Please enter percentage in decimal", txtNRI);
        }

        private void txtNRI_Leave(object sender, EventArgs e)
        {
            toolTip1.Hide(txtNRI);
        }

        private void txtGasEscl_TextChanged(object sender, EventArgs e)
        {
            toolTip2.Show("Please enter percentage in decimal", txtGasEscl);
        }

        private void txtGasEscl_Leave(object sender, EventArgs e)
        {
            toolTip2.Hide(txtGasEscl);
        }


        private void txtLOEEscl_TextChanged(object sender, EventArgs e)
        {
            toolTip3.Show("Please enter percentage in decimal", txtLOEEscl);
        }

        private void txtLOEEscl_Leave(object sender, EventArgs e)
        {
            toolTip3.Hide(txtLOEEscl);
        }


        private void txtOilEscl_TextChanged(object sender, EventArgs e)
        {
            toolTip4.Show("Please enter percentage in decimal", txtOilEscl);
        }

        private void txtOilEscl_Leave(object sender, EventArgs e)
        {
            toolTip4.Hide(txtOilEscl);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            txtAParam.Text = "";
            txtBParam.Text = "";
            txtBPM.Text = "";
            txtGasEscl.Text = "";
            txtGasPrice.Text = "";
            txtLOEEscl.Text = "";
            txtLOEMonth.Text = "";
            txtMonths.Text = "";
            txtNRI.Text = "";
            txtOilEscalation.Text = "";
            txtWellName.Text = "";
            txtOilPrice.Text = "";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}