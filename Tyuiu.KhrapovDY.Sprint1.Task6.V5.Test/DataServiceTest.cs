using Tyuiu.KhrapovDY.Sprint1.Task6.V5.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task6.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckMethodValid()
    {
        DataService ds = new DataService();
        string text = "����� ������ �����, ���� �����, ���";
        string res = ds.CheckSymmetricalWords(text);
        Assert.AreEqual("�����, �����, ���", res);
    }
}
