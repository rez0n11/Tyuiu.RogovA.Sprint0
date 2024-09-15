namespace Tyuiu.RogovA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Add(int x, int y) { return x + y; }
        public static int Subtract(int x,int y) { return x - y; }

        public static int Multiply(int x,int y) {return x * y; }

        public static double Divide(double x, double y) { if (y != 0) { return x / y; } else {Console.WriteLine("Err:div by 0"); return -1; } }
    }
}
