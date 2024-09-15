namespace Tyuiu.RogovA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object sumArray(int[] nums)
        {
            var total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            return total;
        }

        public static object subArray(int[] nums)
        {
            var total = 0;
            int index = 0;
            while (index < nums.Length)
            {
                total -= nums[index];index++;
            }
            return total;
        }

        public static object multArray(int[] nums) 
        {
            var total = 1;
            int index = 0;
            do { total *= nums[index]; index++; } while (index < nums.Length);
            return total;
        }

    }
}
