using Tyuiu.KhrapovDY.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 1;
            int b = 2;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(6, res);
        }
    }
}