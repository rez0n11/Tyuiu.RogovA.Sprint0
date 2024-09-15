using Tyuiu.RogovA.Sprint0.Task5.V0.Lib;
using System;

namespace Tyuiu.RogovA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = "+DataService.Add(1, 5));
            Console.WriteLine("A - B = "+ DataService.Subtract(15, 5));
            Console.WriteLine("A * B = "+ DataService.Multiply(10, 10));
            Console.WriteLine("A / B = "+ DataService.Divide(5, 0));
            Console.ReadKey();
        }
    }
}