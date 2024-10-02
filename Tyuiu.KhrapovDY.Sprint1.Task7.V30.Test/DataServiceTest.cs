using Tyuiu.KhrapovDY.Sprint1.Task7.V30.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 2;
            double z = 2.28;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}