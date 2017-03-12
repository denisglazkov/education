using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.CodeDom;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace LineRegretion
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string fileObj = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"../../test (1).json");
            JArray arrObj = JArray.Parse(fileObj);
            List<Point> list = arrObj.ToObject<List<Point>>();
            int sumX = 0;
            int sumY = 0;
            double sigmaTop = 0;
            double sigma2 = 0;
            double x = 0;
            double y = 0;
            double sigma = 0;
            double a;
            double b;
            double sumProisv = 0;


            foreach ( Point point in list)
            {
                sumX += point.x;
                sumY += point.y;
                sumProisv += point.x * point.y;
            }

            x = (double)sumX / list.Count;
            y = (double)sumY / list.Count;


            foreach (Point point in list)
            {
                sigmaTop += Math.Pow((point.x - x), 2);
            }

            sigma2 = sigmaTop / list.Count;
            sigma = Math.Sqrt(sigma2);

            b =(sumProisv / list.Count - x * y) / sigma2;
            a = y - b * x;

            Console.WriteLine("b - "+ b);
            Console.WriteLine("a - "+ a);
            Console.WriteLine("sumX "+ sumX);
            Console.WriteLine("sumY "+ sumY);
            Console.WriteLine("sigma "+ sigma);
            Console.WriteLine("sigma2 "+ sigma2);
            Console.WriteLine("sumY "+ sumY);
            Console.WriteLine("x "+ x);
            Console.WriteLine("y "+ y);
            Console.WriteLine("sumProisv "+ sumProisv);



//            foreach (Point r in list)
//            {
//                Console.WriteLine(/*"x:"+ r.x+ ", y:"+ r.y*/r.x);
//            }
//            Console.WriteLine("Hello World");
        }

    }
}