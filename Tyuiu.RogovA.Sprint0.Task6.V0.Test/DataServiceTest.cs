using Tyuiu.RogovA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.RogovA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAddArray()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.sumArray(nums);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubArray()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.subArray(nums);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultArray()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.multArray(nums);
            Assert.AreEqual(120, res);
        }
    }
}