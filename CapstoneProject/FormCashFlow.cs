using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace CapstoneProject
{
    public partial class FormCashFlow : Form
    {
        public FormCashFlow()
        {
            InitializeComponent();

            //this.MinimumSize = new Size(1650, 800);
             cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7}
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                    PointGeometry = null
                },
                new LineSeries
                { 
                    Title = "Series 2", 
                    Values = new ChartValues<double> {5, 2, 8, 3},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            //modifying the series collection will animate and update the chart
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
                LineSmoothness = 0, //straight lines, 1 really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = System.Windows.Media.Brushes.Gray
            });

            //modifying any series values will also animate and update the chart
            cartesianChart1.Series[2].Values.Add(5d);


            cartesianChart1.DataClick += CartesianChart1OnDataClick;
        }

        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }

        private void FormCashFlow_Load(object sender, EventArgs e)
        {
            CashFlow cash = new CashFlow();
            cash.modf(dataGridView1);
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CashFlow cash = new CashFlow();

            //double cashFlow = cash.gas_rate(8);
            //textBox1.Text = cashFlow.ToString();

            int months = 119;
            double BPM = 10.00;
            double OIL_ESCL = 0.04;
            double OIL_PRICE = 42.00;

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



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}