namespace Tyuiu.RogovA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AddArrays(int[] arr1, int[] arr2)
        {
            int[] resultArray = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++) { resultArray[i] = arr1[i] + arr2[i]; }
            return resultArray;
        }
    }
}
