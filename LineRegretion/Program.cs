using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace LineRegretion
{

    internal class Program
    {
        public static int Summ(int[,] s)
        {
            int sum1 = 0;
            foreach (int d in s)
            {
                sum1 += d;
            }
            return sum1;
        }

        public static int Pow(int r)
        {
            int y;
            y = Math.Pow(r, 2);
            return y;
        }

        public static void Main(string[] args)
        {
            int[,] a = new int[14, 2]
            {
                {100, 70}, {105, 79}, {108, 85}, {113, 84}, {118, 85}, {118, 85}, {110, 96}, {115, 99}, {119, 100},
                {118, 98}, {120, 99}, {124, 102}, {129, 105}, {132, 112}
            };



            Console.WriteLine(Summ(a));

            Console.WriteLine(Pow(Summ(a)));

//            Console.WriteLine(Algebra.Sum(a));


//            StreamReader reader = new StreamReader(@"/Users/denisglazkov/Downloads/test.json");
//            JArray arrObj = JArray.Parse("[12, 12, 23, 34]");
//            int[] array = arrObj.ToObject<int[]>();
            Console.WriteLine("Hello world");


        }
    }
}