using System.Collections.Generic;

namespace Regression
{
    public class Linear : Regression
    {
        public double a { get; set; }
        public double b { get; set; }

        public override void Calculation()
        {
            Calculate();
            b = (sumMltp / points.Count - avgX * avgY) / sigmaPow;
            a = avgY - b * avgX;
        }
    }
}