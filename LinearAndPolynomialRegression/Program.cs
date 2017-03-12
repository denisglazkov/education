using System;
using System.Collections.Generic;
using System.IO;

namespace LinearAndPolynomialRegression
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fileObj = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"../../test.json");
            Console.WriteLine(fileObj);

            Point qaz = new Point();
            List<Point> re = qaz.jsonToObject(fileObj);

            LinearRegration liner = new LinearRegration();
            Console.WriteLine(liner.summXY);
            Console.WriteLine(liner.sumX);
            Console.WriteLine(liner.sumY);

        }
    }
}