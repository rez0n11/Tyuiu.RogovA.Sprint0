using Tyuiu.RogovA.Sprint0.Task4.V0.Lib;
using System;

namespace Tyuiu.RogovA.Sprint0.Task3.V0
{
    class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine(DataService.Add(1, 5));
            Console.WriteLine(DataService.Subtract(15, 5));
            Console.WriteLine(DataService.Multiply(10, 10));
            Console.WriteLine(DataService.Divide(5, 5));
            Console.ReadKey();
        }
    }
}