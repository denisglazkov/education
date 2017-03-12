using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Newtonsoft.Json.Linq;

namespace LineRegrationV2
{
    public class LinearRegression
    {
        public static string Test = "Hello World";
        public double A { get; set; }
        public double B { get; set; }
        public List<Point> points { get; set; }

        public List<Point> ListPoint(List<Point> list_)
        {
            points = list_;
            return list_;
        }

        public static void sayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void calculate()
        {
            // points = ...
            // y = a*x + b
            // points
            // use points find a & b
            A = 4;
            B = 3;
        }

        public void paintGraph()
        {
            double newY = predict(5);
            // use a & b & points paint graph
        }

        public double predict(int x)
        {
            double y = 5;
            return y;
        }


    }
}