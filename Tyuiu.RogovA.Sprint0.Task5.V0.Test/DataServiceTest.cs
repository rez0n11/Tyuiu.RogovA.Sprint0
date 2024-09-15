using Tyuiu.RogovA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.RogovA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdd() {Assert.AreEqual(10, DataService.Add(5, 5));}
        [TestMethod]
        public void CheckSubtract() {Assert.AreEqual(5, DataService.Subtract(10, 5));}
        [TestMethod]
        public void CheckMultiply() {Assert.AreEqual( 25, DataService.Multiply(5, 5)); }
        [TestMethod]
        public void CheckDivide() { Assert.AreEqual(1,DataService.Divide(5, 5)); }
    }
}