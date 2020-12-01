using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapstoneProject
{
    class CashFlow
    {
        // declare variables
        //int month = 5;


        //input variables
         //A_PARAM = 90000,
        

        // declare the function

        //Gas Rate MMCF/Month ***************************************************************************************************************
        // Gas_rate = calculated value
        // A_PARAM * EXP(B_PARAM * n)


        public void addGasRate(DataGridView d1, int month, double A_PARAM, double B_PARAM)
        {
            double gasRate;
            d1.Rows[0].Cells["Gas_Rate"].Value = A_PARAM;
            for (int i = 1; i < month; i++)
            {

                d1.Rows[i].Cells["Gas_Rate"].Value = gasRate = A_PARAM * Math.Exp(B_PARAM * (i + 1));

            }
        }
        //*********************************************************************************************************************************


        //Table*************************************************************************************************************************

        // initialize the columns
        public void modf(DataGridView d1)
        {

            d1.ColumnCount = 11;
            d1.Columns[0].Name = "Month";
            d1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[1].Name = "Gas_Rate";
            d1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[2].Name = "Gas_Price";
            d1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[3].Name = "Cum_MMCF";
            d1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[4].Name = "Oil_Rate";
            d1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[5].Name = "Oil_Price";
            d1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[6].Name = "Cum_Oil";
            d1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[7].Name = "LOE";
            d1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[8].Name = "Gross_Rev";
            d1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[9].Name = "Net_Rev";
            d1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d1.Columns[10].Name = "Sum_NetRev";
            d1.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            d1.Columns["Month"].HeaderText = "Month";

            d1.Columns["Gas_Rate"].HeaderText = "Gas Rate";
            d1.Columns["Gas_Rate"].DefaultCellStyle.Format = "N0";
        
            d1.Columns["Gas_Price"].HeaderText = "Gas Price";
            d1.Columns["Gas_Price"].DefaultCellStyle.Format = "c";
          
            d1.Columns["Cum_MMCF"].HeaderText = "Cummulative MMCF";
            d1.Columns["Cum_MMCF"].DefaultCellStyle.Format = "N0";
         
            d1.Columns["Oil_Rate"].HeaderText = "Oil Rate";
            d1.Columns["Oil_Rate"].DefaultCellStyle.Format = "N0";
           
            d1.Columns["Oil_Price"].HeaderText = "Oil Price";
            d1.Columns["Oil_Price"].DefaultCellStyle.Format = "c";
           
            d1.Columns["Cum_Oil"].HeaderText = "Cummulative Oil";
            d1.Columns["Cum_Oil"].DefaultCellStyle.Format = "N0";
     
            d1.Columns["LOE"].HeaderText = "Lease Operating Expense";
            d1.Columns["LOE"].DefaultCellStyle.Format = "c";
          
            d1.Columns["Gross_Rev"].HeaderText = "Gross Revenue";
            d1.Columns["Gross_Rev"].DefaultCellStyle.Format = "c";
           
            d1.Columns["Net_Rev"].HeaderText = "Net Revenue";
            d1.Columns["Net_Rev"].DefaultCellStyle.Format = "c";
    
            d1.Columns["Sum_NetRev"].HeaderText = "Sum of Net Revenue";
            d1.Columns["Sum_NetRev"].DefaultCellStyle.Format = "c";
            

        }

        // populate the table with rows
        public void addRows(DataGridView d1, int month)
        {
            for (int i = 1; i < month; i++)
            {
                d1.Rows.Add();
            }
        }

        // Month
        public void addMonth(DataGridView d1, int month)
        {

            for (int i = 0; i < month; i++)
            {

                d1.Rows[i].Cells["Month"].Value = (i + 1);
            }

        }

        // Gas Price*************************************************************************************
        // g, gas price (first month)
        // g + g * GAS_ESCL/12
        public void addGasPrice(DataGridView d1, int month, double GAS_PRICE, double GAS_ESCL)
        {
            double[] gasPrice = new double[month];
            double[] tmpArray = new double[month];
            gasPrice[0] = GAS_PRICE;

            /*if (month == 1)
            {
                d1.Rows.Add();
                d1.Rows.Add(GAS_PRICE);
            
            else*/

            //d1.Rows.Add();
            for (int i = 1; i < month; i++)
            {
                gasPrice[i] = gasPrice[i - 1] + gasPrice[i - 1] * (GAS_ESCL / 100) / 12;
                d1.Rows[0].Cells["Gas_Price"].Value = gasPrice[0];
                d1.Rows[i].Cells["Gas_Price"].Value = gasPrice[i];
            }

        }

        // Cummulative MMCF********************************************************************************
        // gas_rate(n) + gas_rate(n + 1)
        public void addCumMMCF(DataGridView d1, int month, double A_PARAM)
        {

            double num = 0;
            double num2 = 0;
            d1.Rows[0].Cells["Cum_MMCF"].Value = A_PARAM;

            for (int i = 1; i <= month; i++)
            {
                num = (double)d1.Rows[i - 1].Cells["Gas_Rate"].Value;
                num = num + num2;
                num2 = num;

                d1.Rows[i - 1].Cells["Cum_MMCF"].Value = num2;

            }
        }

        // Oil Rate BBL per Month*****************************************************************************
        // gas_rate / 1000 * BPM
        public void addOilRateBBLMonth(DataGridView d1, int month, double BPM)
        {
            double num = 0;
            double num2 = 0;
            for (int i = 1; i <= month; i++)
            {
                num = (double)d1.Rows[i - 1].Cells["Gas_Rate"].Value;
                num2 = num / 1000 * BPM;

                d1.Rows[i - 1].Cells["Oil_Rate"].Value = num2;
            }

        }

        // Oil Price**************************************************************************************************
        // Oil_Price(n) First month
        // oil_price(n) + oil_price(n) * OIL_ESCL / 12
        public void addOilPrice(DataGridView d1, int month, double OIL_ESCL, double OIL_PRICE)
        {

            double num = 0;
            double num2 = 0;
            d1.Rows[0].Cells["Oil_Price"].Value = OIL_PRICE;

            for (int i = 1; i < month; i++)
            {
                num = (double)d1.Rows[i - 1].Cells["Oil_Price"].Value;

                num2 = num + num * (OIL_ESCL / 100) / 12;

                d1.Rows[i].Cells["Oil_Price"].Value = num2;
            }
        }

        // Cummulative Oil**************************************************************************
        // oil_rate(n) + oil_rate(n +1)
        public void addCumOil(DataGridView d1, int month)
        {
            double num = 0;
            double num2 = 0;
            d1.Rows[0].Cells["Cum_Oil"].Value = d1.Rows[0].Cells["Oil_Rate"].Value;

            for (int i = 1; i <= month; i++)
            {
                num = (double)d1.Rows[i - 1].Cells["Oil_Rate"].Value;
                num = num + num2;
                num2 = num;

                d1.Rows[i - 1].Cells["Cum_Oil"].Value = num2;

            }
        }

        // Lease of Expense**********************************************************************************
        // LOE_MONTH(n) First month
        // LOE_MONTH(n) + LOE_MONTH(n) * LOE_ESCL / 12
        public void addLOE(DataGridView d1, int month, double LOE_MONTH, double LOE_ESCL)
        {
            double num = 0;
            double num2 = 0;

            d1.Rows[0].Cells["LOE"].Value = LOE_MONTH;

            for (int i = 1; i < month; i++)
            {
                num = (double)d1.Rows[i - 1].Cells["LOE"].Value;

                num2 = num + num * (LOE_ESCL / 100) / 12;

                d1.Rows[i].Cells["LOE"].Value = num2;
            }
        }

        // Gross revenue***************************************************************************************************
        // gas_rate(n) * gas_price(n) + OilRateBBLMonth(n) * oil_price - LOE(n)
        public void addGrossRev(DataGridView d1, int month)
        {
            double gRate = 0;
            double gPrice = 0;
            double oRate = 0;
            double oPrice = 0;
            double LOE = 0;
            double num = 0;

            try
            {
                for (int i = 1; i <= month; i++)
                {
                    gRate = (double)d1.Rows[i - 1].Cells["Gas_Rate"].Value;
                    gPrice = (double)d1.Rows[i - 1].Cells["Gas_Price"].Value;
                    oRate = (double)d1.Rows[i - 1].Cells["Oil_Rate"].Value;
                    oPrice = (double)d1.Rows[i -1].Cells["Oil_Price"].Value;
                    LOE = (double)d1.Rows[i - 1].Cells["LOE"].Value;

                    num = gRate * gPrice + oRate * oPrice - LOE;
                    //num = num + oRate;
                    //num = num * oPrice;
                    //num = num - LOE;

                    d1.Rows[i - 1].Cells["Gross_Rev"].Value = num;
                }

            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("There was an error, please try again. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Net revenue**************************************************************************
        // NRI * GROSS_REV(n)
        public void addNetRev(DataGridView d1, int month, double NRI)
        {
            double gRev = 0;
            double num = 0;

            for  (int i = 1; i <= month; i++)
            {
                gRev = (double)d1.Rows[i - 1].Cells["Gross_Rev"].Value;
                num = gRev * (NRI / 100);

                d1.Rows[i - 1].Cells["Net_Rev"].Value = num;
            }
        }

        // Sum of Net Revenue, SNR
        // SNR = NET_REV(n) First Month
        // NET_REV + SNR(n - 1) it takes net revenue of the current month and adds it to running total, SNR
        public void addSumOfNetRev(DataGridView d1, int month)
        {
            double num = 0;
            double num2 = 0;

            d1.Rows[0].Cells["Sum_NetRev"].Value = d1.Rows[0].Cells["Net_Rev"].Value;

            for (int i = 1; i <= month; i++)
            {
                num = (double)d1.Rows[i - 1].Cells["Net_Rev"].Value;
                num = num + num2;
                num2 = num;
                       
                d1.Rows[i - 1].Cells["Sum_NetRev"].Value = num2;
                

            }
        }
    }
}
