using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    class CashFlow
    {
        // declare variables
        //int month = 5;


        //input variables
        double A_PARAM = 90000,
               B_PARAM = -0.026,
               GAS_PRICE = 2.5,
               GAS_ESCL = 0.05,
               LOE_MONTH = 1300,
               LOE_ESCL = 0.04,
               DISC_RATE = 0.00,
               NRI = 0.0925,
               BPM = 10.00,
               OIL_PRICE = 42,
               OIL_ESC = 0.04;

        // declare the function

        //Gas Rate MMCF/Month ***************************************************************************************************************
        // Gas_rate = calculated value
        public void addGasRate(DataGridView d1, int month)
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
            d1.Columns[1].Name = "Gas_Rate";
            d1.Columns[2].Name = "Gas_Price";
            d1.Columns[3].Name = "Cum_MMCF";
            d1.Columns[4].Name = "Oil_Rate";
            d1.Columns[5].Name = "Oil_Price";
            d1.Columns[6].Name = "Cum_Oil";
            d1.Columns[7].Name = "LOE";
            d1.Columns[8].Name = "Gross_Rev";
            d1.Columns[9].Name = "Net_Rev";
            d1.Columns[10].Name = "Sum_NetRev";

            d1.Columns["Month"].HeaderText = "Month";
            d1.Columns["Gas_Rate"].HeaderText = "Gas Rate";
            d1.Columns["Gas_Price"].HeaderText = "Gas Price";
            d1.Columns["Cum_MMCF"].HeaderText = "Cummulative MMCF";
            d1.Columns["Oil_Rate"].HeaderText = "Oil Rate";
            d1.Columns["Oil_Price"].HeaderText = "Oil Price";
            d1.Columns["Cum_Oil"].HeaderText = "Cummulative Oil";
            d1.Columns["LOE"].HeaderText = "Lease Operating Expense";
            d1.Columns["Gross_Rev"].HeaderText = "Gross Revenue";
            d1.Columns["Net_Rev"].HeaderText = "Net Revenue";
            d1.Columns["Sum_NetRev"].HeaderText = "Sum Net Revenue";

        }

        // populate the table with rows
        public void addRows(DataGridView d1, int month)
        {
            for (int i = 1; i < month; i++)
            {
                d1.Rows.Add();
            }
        }

        public void addMonth(DataGridView d1, int month)
        {

            for (int i = 0; i < month; i++)
            {

                d1.Rows[i].Cells["Month"].Value = (i + 1);
            }

        }
        public void addGasPrice(DataGridView d1, int month)
        {
     
            // For the function Gas Price**********************************************************
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
                gasPrice[i] = gasPrice[i - 1] + gasPrice[i - 1] * GAS_ESCL / 12;
                d1.Rows[0].Cells["Gas_Price"].Value = gasPrice[0];
                d1.Rows[i].Cells["Gas_Price"].Value = gasPrice[i];
            }

        }

    }
}
