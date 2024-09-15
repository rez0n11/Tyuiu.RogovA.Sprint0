using System;

using Tyuiu.RogovA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RogovA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Саша"));
            Console.ReadKey();
        }
    }
}