using Tyuiu.RogovA.Sprint0.Task7.V0.Lib;
namespace Tyuiu.RogovA.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            int[] nums2 = { 1, 2, 3, 4, 5 };
            int[] numsr = { 2, 4, 6, 8, 10 };
            int[] res= DataService.AddArrays(nums1, nums2);
            CollectionAssert.AreEqual(numsr, res);
        }
    }
}