using System;

namespace BMIValueCalculationLib
{
    public class BmiValueCalculation
    {

        //private double bmivalue;

        public double Calculator(double height, double weight)
        {
          double  bmivalue = weight / height;
            return bmivalue;
        }

    }
}
