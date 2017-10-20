using Lab2.ConsoleApp.DataTypes;
using Lab2.ConsoleApp.Iterations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ConsoleApp
{
    class Program
    {
        static int x;
        static int y = 0;

        static void Main(string[] args)
        {
            WorkingWithIterations workingWithIterations = new WorkingWithIterations();
            //workingWithIterations.IfElseExample();
            //workingWithIterations.SwitchOnStringExample();
            //workingWithIterations.WhileLoopExample();
            workingWithIterations.ForEachLoopExample();

            Console.ReadKey();
        }

        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats: ");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }

        static string StringWork(char x)
        {
            string y = x.ToString();

            return StringWork1(y);
        }

        static string StringWork1(string s)
        {
            return s.ToUpper();
        }

        static int Add(int x, int y)
        {
            Console.WriteLine("X = {0} {1}", x, "6 cai");
            Console.WriteLine("Y = {0}", y);
            return x + y;
        }

        static int Add2(int x)
        {
            return x + 2;
        }



    }
}
