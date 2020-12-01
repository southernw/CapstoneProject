using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    // Calculates recoverable gas
    class GasCalculation
    {
        // Declare variables
        public const double ACRE = 43560.00;
        double bhp, sw, acres, recFactor, netH, avgPorosity, bblMillion, depth;
        int numWells;

        public GasCalculation(double bhp, double sw, double recFactor, double acres, double netH, double avgPorosity, double bblMillion, double depth, int numWells)
        {
            this.bhp = bhp;
            this.sw = sw;
            this.acres = acres;
            this.recFactor = recFactor;
            this.netH = netH;
            this.avgPorosity = avgPorosity;
            this.bblMillion = bblMillion;
            this.depth = depth;
            this.numWells = numWells;
        }

        // Declaring the functions
        double getBHP() { return bhp; }
        double getSW() { return sw; }
        double getAcres() { return acres; }
        double getRecFactor() { return recFactor; }
        double getNetH() { return netH; }
        double getAvgPorosity() { return avgPorosity; }
        double getBBLMillion() { return bblMillion; }
        double getDepth() { return depth; }
        double getNumWells() { return numWells; }

        // Porosity Feet
        // F12
        public double calcPorFeet(double netH, double avgPorosity)
        {
            double porFeet = 0.0;
            double percAP = avgPorosity / 100;
            porFeet = (netH * percAP);
            return porFeet;
        }

        // Mud Weight Estimated
        // G6
        public double calcMWE(double bhp, double depth)
        {
            // BHP/0.052/Depth
            double tempF = bhp / 0.052;
            double MWE = tempF / depth;
                return MWE;
        }

        // MMCF / Porocity Feet
        // F9
        public double calcMMCF_PORFT(double acres, double sw, double bhp, double recFactor)
        {
            // acres *43560*(1-water saturation)*(BHP/15)*Recovery Factor/1000000

            double sqftAcre = acres * ACRE;
            double swOne = (100 - sw);
            double bhpFif = (bhp / 15);
            double recFacOne = ((recFactor / 100) / 100000000);

            double MMCF_PORFT = sqftAcre * swOne * bhpFif * recFacOne;
            return MMCF_PORFT;
        }
        
        // Per Well MMCF
        //F12
        public double calcPerWellMMCF(double porFeet, double MMCF_PORFT)
        {
            //Porosity Feet * MMCF/PorFeet
            double perWellMMCF = porFeet * MMCF_PORFT;

            return perWellMMCF;
        }
        //BO Per Well
        // C18
        public double calcPerWellBO(double bblMillion, double MMCF, double perWellMMCF) 
        {
            // BBL / mil * MMCF
            double perWellBO = (bblMillion * perWellMMCF);

            return perWellBO;
        }
        // Total Reserves Calculations
        // D22
        public double calcTotalResMMCF(double perWellMMCF, double numWells)
        {
            // PerWellMMCF * numWells
            double totalResMM = perWellMMCF * numWells;

            return totalResMM;
        }
        // Total Reserves BO
        // C22
        public double calcTotalResBO(double perWellBO, double numWells)
        {
            //PerWellBO * numWells

            /*
            double mmcfPorFt2 = calcMMCF_PORFT(acres, sw, bhp, recFactor);
            double porosityFeet = calcPorFeet(netH, avgPorosity);
            double perWellMMCF = porosityFeet / mmcfPorFt2;

            double perWellBO2 = (bblMillion * perWellMMCF);

            */
            double totalResBO = perWellBO * numWells;

            return totalResBO;
        }
    }
}
