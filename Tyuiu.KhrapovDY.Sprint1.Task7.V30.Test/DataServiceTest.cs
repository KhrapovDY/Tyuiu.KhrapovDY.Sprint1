using Tyuiu.KhrapovDY.Sprint1.Task7.V30.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 12.291;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}