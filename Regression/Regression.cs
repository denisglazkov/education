using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Regression
{
    abstract public class Regression
    {
        protected List<Point> points { get; set; }
        public double avgX { get; set; }
        public double avgLgX { get; set; }
        public double avgY { get; set; }
        public double avgLgY { get; set; }
        public double sigmaPow { get; set; }
        public double sigmaPowLg { get; set; }
        public double sigma { get; set; }
        public double sumMltp { get; set; }
        public double sumMltpLg { get; set; }

        public abstract void Calculation();

        public void InitPoint(List<Point> points_)
        {
            points = points_;
        }

        protected void Calculate()
        {
            foreach (Point xxx in points)
            {
                avgX += xxx.x;
                avgY += xxx.Y;
                avgLgX += Math.Log10(xxx.x);
                avgLgY += Math.Log10(xxx.Y);
                sumMltp += xxx.x * xxx.Y;
                sumMltpLg += Math.Log10(xxx.x) * Math.Log10(xxx.Y);
            }

            avgX = avgX / points.Count;
            avgLgX = avgLgX / points.Count;
            avgY = avgY / points.Count;
            avgLgY = avgLgY / points.Count;

            foreach (Point xxx in points)
            {
                sigmaPow += Math.Pow(xxx.x - avgX, 2);
                sigmaPowLg += Math.Pow(Math.Log10(xxx.x) - Math.Log10(avgX), 2);
            }

            sigmaPow = sigmaPow / points.Count;
            sigmaPowLg = sigmaPowLg / points.Count;
            sigma = Math.Sqrt(sigmaPow);
        }
    }
}