using Tyuiu.RogovA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.RogovA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main()
        {
            int[] arraynums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива:"+DataService.sumArray(arraynums));
            Console.WriteLine("Разность элементов массива:" + DataService.subArray(arraynums));
            Console.WriteLine("Произведение элементов массива:" + DataService.multArray(arraynums));
        }
    }
}