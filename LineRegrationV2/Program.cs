using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LineRegrationV2;
using Newtonsoft.Json.Linq;

namespace LineRegrationV2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int e = 0;
            string fileObj = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"../../test.json");
            JArray arrObj = JArray.Parse(fileObj);
            List<Point> list = arrObj.ToObject<List<Point>>();
            Console.WriteLine(LinearRegression.Test);
            LinearRegression reg = new LinearRegression();
            reg.ListPoint(list);
//            reg.points = list;
            reg.calculate();
            reg.paintGraph();
//            MainProgram program = getProgram();
//            program.initData(new []{1,2});
//            Console.WriteLine(program.calculate());
//            program.calculate();

        }

        public static MainProgram getProgram()
        {
            Random rand = new Random();
            int i = rand.Next(0,1);
            if (i == 1)
            {
                return new Life();
            }
            else
            {
                return new Junior();
            }
        }
    }

    abstract class MainProgram
    {
        public void initData(int[] a)
        {

        }
        public abstract string calculate();
    }

    class Life : MainProgram
    {
        public override string calculate()
        {
            string word = "In Life";
            return word;
        }

        public void sayHello()
        {
            Console.WriteLine("hello!");
        }
    }
    class Junior : MainProgram
    {
        public override string calculate()
        {
            string word = "In Junior";
            return word;
        }
        public void sayHello()
        {
            Console.WriteLine("hello!");
        }
    }
}