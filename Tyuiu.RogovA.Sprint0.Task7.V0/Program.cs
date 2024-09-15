using Tyuiu.RogovA.Sprint0.Task7.V0.Lib;
using System;

namespace Tyuiu.RogovA.Sprint0.Task7.V0
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #0");
            Console.WriteLine("* Тема:Создание итогового решения по спринту  ");
            Console.WriteLine("* Задание #7");
            Console.WriteLine("* Вариант #0");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Исходные данные:");
            Console.WriteLine(new string('*', 75));


            int[] arraynums1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine();
            for (int i = 0; i < arraynums1.Length; i++)
            {
                Console.Write(arraynums1[i] + ", ");
            }
            Console.WriteLine();
            int [] arraynums2 = { 1,2, 3, 4,5 };
            for (int i = 0;i < arraynums2.Length; i++) { Console.Write(arraynums2[i] + ", "); }
            Console.WriteLine();
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Результат:");
            Console.WriteLine(new string('*', 75));

            if (arraynums1.Length == arraynums2.Length) 
            {
                int[] resultArray = DataService.AddArrays(arraynums1,arraynums2);
                Console.WriteLine("Сумма элементов массива равна:");
                for (int i = 0; i < arraynums1.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }

            else
            {
                Console.WriteLine("Error: Длины массивов не совпадают");
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 75));
            Console.ReadKey();
        }
    }
}