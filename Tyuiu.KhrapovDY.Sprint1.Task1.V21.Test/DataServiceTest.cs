using Tyuiu.KhrapovDY.Sprint1.Task1.V21.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.2, res);
        }
    }
}