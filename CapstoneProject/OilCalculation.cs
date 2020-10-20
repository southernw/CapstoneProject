
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CapstoneProject
{
    // Calculates recoverable oil
    class OilCalculation
    {
        // Constant variables. ACRE and cubic foot are static.
        public const double ACRE = 43560.00;
        public const double CUBIC_FOOT = 0.178108;

        // declaring the variables.
        double thickness, porosity, waterSat, area, recFactor;
        public OilCalculation(double thickness, double porosity, double waterSat, double area, double recFactor)
        {
            this.thickness = thickness;
            this.porosity = porosity;
            this.waterSat = waterSat;
            this.area = area;
            this.recFactor = recFactor;

        }

        // declaring the functions
        public double getThickness() { return thickness; }
        public double getPorosity() { return porosity; }
        public double getWaterSat() { return waterSat; }
        public double getArea() { return area; }
        public double getRecFator() { return recFactor; }

        //Porosity Feet
        public double calcPorFeet(double thickness, double porosity)
        {
            double porFeet = 0.0;

            thickness = this.thickness;
            porosity = this.porosity;

            porFeet = (thickness * porosity / 100);

            return porFeet;
        }

        //Barrels of Oil per Acre
        public double calcBblPerAcre(double porFeet, double waterSat)
        {
            // PorFeet *43560 * 0.178108 * (1-waterSat/100)
            porFeet = calcPorFeet(this.thickness, this.porosity);

            double bblPerAcre = (porFeet * ACRE * CUBIC_FOOT) * (1 - waterSat / 100);

            return bblPerAcre;
        }

        //Barrels of Oil Original Oil in place
        public double calcBblPerOoip(double bblPerAcre, double area)
        {
            //bbPerAcre * Area /1.05
            double porFeet = calcPorFeet(this.thickness, this.porosity);

            bblPerAcre = (porFeet * ACRE * CUBIC_FOOT) * (1 - waterSat / 100);

            double bblPerOoip = (bblPerAcre * area / 1.05);

            return bblPerOoip;

        }

        //Barrels of oil Recovery
        public double calcBblRecov(double bblPerOoip, double recFactor)
        {
            //bblPerOoip * recFactor /100

            recFactor = getRecFator();
            double porFeet = calcPorFeet(this.thickness, this.porosity);
            double bblPerAcre = (porFeet * ACRE * CUBIC_FOOT) * (1 - waterSat / 100);
            double bblRecov = (bblPerOoip * recFactor) / 100;
            return bblRecov;

        }

        //BO/ACRE Equiv.
        public double calcBoEq(double bblRecov, double area, double thickness)
        {
            // BBLrec / Area / Thickness
            double boEq = (bblRecov / this.thickness);
            double boEq2 = (boEq / area);

            return boEq2;
        }
    }
}
