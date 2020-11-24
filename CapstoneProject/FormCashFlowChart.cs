using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;


namespace CapstoneProject
{
    public partial class FormCashFlowChart : Form
    {
        public DataGridView MyDgv;
        //public string wellName;
        public string w;


        public FormCashFlowChart(DataGridView dgv, string wellName)
        {

            InitializeComponent();
            MyDgv = dgv;
            w = wellName;
            
            
            var cumMMCF = new List<double>();
            foreach (DataGridViewRow row in MyDgv.Rows)
            {
                cumMMCF.Add((double)row.Cells[3].Value);

            }

            var gasRate = new List<double>();
            foreach (DataGridViewRow row in MyDgv.Rows)
            {
                gasRate.Add((double)row.Cells[1].Value);

            }

            var sumNetRev = new List<double>();
            foreach (DataGridViewRow row in MyDgv.Rows)
            {
                sumNetRev.Add((double)row.Cells[10].Value);

            }

            var months = new List<int>();
            foreach (DataGridViewRow row in MyDgv.Rows)
            {
                months.Add((int)row.Cells[0].Value);

            }

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Cum MMCF",
                    Values = cumMMCF.AsChartValues(),
                    PointGeometry = null,
                    ScalesYAt = 2

                },
                new LineSeries
                {
                    Title = "Gas Rate",
                    Values = gasRate.AsChartValues(),
                    PointGeometry = null,
                    ScalesYAt = 0

                },
                new LineSeries
                {
                    Title = "Sum of Net Rev",
                    Values = sumNetRev.AsChartValues(),
                    PointGeometry = null,
                    
                    //PointGeometry = DefaultGeometries.Square,
                   // PointGeometrySize = 15,
                    ScalesYAt = 1
                    

                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Months",
                MinValue = 0,
                MaxValue = getMonths(),
                FontWeight = FontWeights.Bold,
                Foreground = System.Windows.Media.Brushes.Black,
                FontSize = 16,
                Opacity = 0.6
                //Labels = new[] { 0, "20", "40", "60", "May" }
            }) ;

            cartesianChart1.AxisY.Add(new Axis
            {
                
                Title = "MCFG/Month",
                LabelFormatter = value => value.ToString("N0"),
                MinValue = 0,
                MaxValue = 100000,
                FontWeight = FontWeights.Bold,
                Foreground = System.Windows.Media.Brushes.Black,
                FontSize = 16,
                Opacity = 0.6
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                //Title = "MCFG/Month",
                LabelFormatter = value => value.ToString("N0"),
                MinValue = 0,
                MaxValue = 3500000,
                Foreground = System.Windows.Media.Brushes.IndianRed,
                Position = AxisPosition.RightTop,
                FontWeight = FontWeights.Bold,
                FontSize = 18,
                Opacity = 0.6
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString("N0"),
                //Title = "MCFG/Month",
                MinValue = 0,
                MaxValue = 3500000,
                Foreground = System.Windows.Media.Brushes.IndianRed,
                //Position = AxisPosition.RightTop,
                FontWeight = FontWeights.Bold,
                FontSize = 18,
                ShowLabels = false,
                Opacity = 0.0
            });



            cartesianChart1.LegendLocation = LegendLocation.Right;

            //modifying the series collection will animate and update the chart
            //cartesianChart1.Series.Add(new LineSeries
           // {
                //Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
               // LineSmoothness = 1, //straight lines, 1 really smooth lines
               // PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                //PointGeometrySize = 50,
               // PointForeground = System.Windows.Media.Brushes.Gray
           // });

            //modifying any series values will also animate and update the chart
           // cartesianChart1.Series[1].Values.Add(5d);


            cartesianChart1.DataClick += CartesianChart1OnDataClick;
        }



        //public DataGridView modf { get; set; }

        public double getMonths()
        {
            double monthss = (int)MyDgv.Rows[MyDgv.RowCount - 1].Cells[0].Value;
            return monthss;
        }
        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            System.Windows.MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }
       
    
        private void FormCashFlowChart_Load(object sender, EventArgs e)
        {
           
           
            CashFlow cash = new CashFlow();
            
            FormCashFlow formCash = new FormCashFlow();

            label1.Text = w;


            //formCash.str = textBox1.Text.ToString(); 


            // FormCashFlow formCash = new FormCashFlow();
            //this.dataGridView1.DataSource = formCash.dat

            // Form2.DataGridView2.datasource = dt;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "PNG Files (*.png)|*.png";
                saveFileDialog1.Title = "Export Chart to Image";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = label1.Text.ToString();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(cartesianChart1.Width, cartesianChart1.Height);
                    cartesianChart1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(saveFileDialog1.FileName, ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
