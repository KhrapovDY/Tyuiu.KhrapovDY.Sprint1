using Tyuiu.KhrapovDY.Sprint1.Task4.V18.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1; 
            double y = 2;
            double z = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}