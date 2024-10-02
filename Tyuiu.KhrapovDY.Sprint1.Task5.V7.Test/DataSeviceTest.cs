using Tyuiu.KhrapovDY.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.AngleToHoursMinutes(100);
            Assert.AreEqual(3, res);
        }
    }
}