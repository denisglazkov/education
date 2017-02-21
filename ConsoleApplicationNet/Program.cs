using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace ConsoleApplicationNet
{
     class Program
    {
        //lesson
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter number 1");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
            }
        }
        //lesson 8.3

//        public static int GetFibanachiNumber(int num)
//        {
//            int[] a = new int[num];
//            a[0] = 1;
//            a[1] = 1;
//            int n = 0;
//            for (int i = 2; i < num ; i++)
//            {
//                a[i] = a[i - 2] + a[i - 1];
//                n = a[i];
//            }
//
//            return n;
//        }
//
//        public static void Main(string[] args)
//        {
//            int w = 0;
//            Console.WriteLine("Write the number");
//            w = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(GetFibanachiNumber(w));
//        }

        //lesson 8.2

//        public static int GetMaxNumber(int[] array)
//        {
//            int max;
//            max = array[0];
//
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (max < array[i])
//                {
//                    max = array[i];
//                }
//            }
//            return max;
//        }
//
//        public static void Main(string[] args)
//        {
//            Random b = new Random();
//            int[] a = new int[10];
//
//            for (int i = 0; i < 10; i++)
//            {
//                a[i] = b.Next(-10, 10);
//                Console.WriteLine(a[i]);
//            }
//            Console.WriteLine("/nmax = "+ GetMaxNumber(a));
//        }



        //lesson 8.1

//        public static void GetReversNumbers(int[] array)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                array[i] = array[i] * (-1);
//            }
//        }
//
//        public static void Main(string[] args)
//        {
//            Random b = new Random();
//            int[] a = new int[10];
//
//            for (int i = 0; i < 10; i++)
//            {
//                a[i] = b.Next(-10, 10);
//            }
//        }

        //lesson 8 order array

//        public static void Main(string[] args)
//        {
//            int[] a = {2, -2, -3, -1, 34, -21, -11};
//            int i, j, k, n, temp;
//            k = 0;
//            int size = a.Length;
//            temp = a[0];
//
//            for (i = 0; i <  size; i++)
//            {
//                if (a[i] < 0)
//                {
//                    temp = a[i];
//                    for (j = i; k < j; j--)
//                    {
//                        a[j] = a[j - 1];
//                    }
//                    a[k] = temp;
//                    k++;
//                }
//            }
//
//            for (n = 0; n < size; n++)
//            {
//                Console.WriteLine(a[n]);
//            }
//        }



        //lesson 7
//        public static void Main(string[] args)
//        {
//            Random a = new Random();
//            int[] b = {11, 23, 45, 67, 87, 34};
//            int temp, i, j;
//
//
//            foreach (int c in b)
//            {
//                if (c>20 && c<50)
//                {
//                    Console.WriteLine(c);
//                }
//            }
//        }


        //lesson sort
//        public static void Main(string[] args)
//        {
//            Random a = new Random();
//            int[] b = new int[10];
//            int temp, i, j;
//
//            for (int k = 0; k < 10; k++)
//            {
//                b[k] = a.Next(-1000, 1000);
//                Console.WriteLine(b[k]);
//            }
//
//            Console.WriteLine("\nnext");
//
//
//            for (i = 0; i < 10; i++)
//            {
//                for (j = i+1; j < 10; j++)
//                {
//                    if (b[i] > b[j])
//                    {
//                        temp = b[i];
//                        b[i] = b[j];
//                        b[j] = temp;
//                    }
//                }
//                Console.WriteLine(b[i]);
//            }
//        }




        //lesson 4.3
//        public static void Main(string[] args)
//        {
//            int[] a = {1, 4, 2, 5, 7, 4, 2, 6, 12, 14};
//            int[] b = {5, 8, 12, 54, 32, 45, 66, 98, 22, 11};
//            int[] c = new int[10];
//
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(a[i] + " + " + b[i] + " = " + a[i] + b[i]);
//            }
//        }


        //lesson 4.2

//        public static void Main(string[] args)
//        {
//            int a;
//
//            do
//            {
//                Console.WriteLine("enter password");
//                a = Convert.ToInt32(Console.ReadLine());
//            }
//            while (a != 12345);
//        }


        //lesson 4.1

//        public static void Main(string[] args)
//        {
//            int a = 1;
//            for (int i = 1; i < 21; i++)
//            {
//                Console.WriteLine(i+ " - " +a);
//                a = a + 3;
//            }
//        }

        //lesson2.2
//        public static void Main(string[] args)
//        {
//            int a = 21, b = 42, c = 1, d_1 = 3, d_2 = 7;
//
//            if (a%d_1 == 0 && a%d_2 == 0)
//            {
//                Console.WriteLine(a+ " Kratnoe");
//            }
//            else
//            {
//                Console.WriteLine(a+" Ne krantoe");
//            }
//            if (b%d_1 == 0 && b%d_2 == 0)
//            {
//                Console.WriteLine(b+ " Kratnoe");
//            }
//            else
//            {
//                Console.WriteLine(b+" Ne krantoe");
//            }
//            if (c%d_1 == 0 && c%d_2 == 0)
//            {
//                Console.WriteLine(c+ " Kratnoe");
//            }
//            else
//            {
//                Console.WriteLine(c+" Ne krantoe");
//            }
//        }

        //lesson 2.1
//        public static void Main(string[] args)
//        {
//            int a, b;
//            Console.WriteLine("Host goals");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Guest goals");
//            b = Convert.ToInt32(Console.ReadLine());
//            if (a>b)
//            {
//                Console.WriteLine("Host won");
//            }
//            else
//            {
//                if (a == b)
//                {
//                    Console.WriteLine("Nichia");
//                }
//                else
//                {
//                    Console.WriteLine("Gueast won");
//                }
//            }
//        }


        //lesson 1
//        public static void Main(string[] args)
//        {
//            int a = 5, b = 7, gamma=90;
//            Console.WriteLine((a*b)/2);
//            Console.WriteLine(Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2)));
//            Console.WriteLine(Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2)-2*a*b*Math.Cos(gamma)));
//            Console.ReadKey();
//        }
    }
}