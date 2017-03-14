using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Regression
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fileObj = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"../../testData.json");

            Point list = new Point();
            List<Point> createPoint = Point.GetPoint(fileObj);

            Linear initLinear = new Linear();
            initLinear.InitPoint(createPoint);
            initLinear.Calculation();

            Polynomial initPolnomial = new Polynomial();
            initPolnomial.InitPoint(createPoint);
            initPolnomial.Calculation();

            Console.WriteLine("Linear A "+ initLinear.a);
            Console.WriteLine("Linear B "+ initLinear.b);

            Console.WriteLine("Polinomial A "+ initPolnomial.a);
            Console.WriteLine("Polinomial B "+ initPolnomial.b);

            Chart

        }
    }
}