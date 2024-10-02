using Tyuiu.KhrapovDY.Sprint1.Task6.V5.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task6.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckMethodValid()
    {
        DataService ds = new DataService();
        string text = "казак пробел ложка, туда шалаш, как";
        string res = ds.CheckSymmetricalWords(text);
        Assert.AreEqual("казак, шалаш, как", res);
    }
}
