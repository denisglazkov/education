using System.Collections.Generic;

namespace Regression
{
    public class Polynomial : Regression
    {
        public double a { get; set; }
        public double b { get; set; }

        public override void Calculation()
        {
            Calculate();
            b = (sumMltpLg / points.Count - avgLgX * avgLgY) / sigmaPowLg;
            a = avgLgY - b * avgLgX;
        }
    }
}