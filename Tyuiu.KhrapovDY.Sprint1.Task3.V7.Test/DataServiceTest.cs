using Tyuiu.KhrapovDY.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double verst = 1;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(1.067, res);
        }
    }
}