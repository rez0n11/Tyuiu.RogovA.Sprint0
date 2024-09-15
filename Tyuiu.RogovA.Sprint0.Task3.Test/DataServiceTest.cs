using Tyuiu.RogovA.Sprint0.Task3.Lib;
namespace Tyuiu.RogovA.Sprint0.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.sum(5, 5));
        }
    }
}