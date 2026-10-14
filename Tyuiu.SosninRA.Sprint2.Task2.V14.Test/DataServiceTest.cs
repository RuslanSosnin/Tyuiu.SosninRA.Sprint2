using Tyuiu.SosninRA.Sprint2.Task2.V14.Lib;

namespace Tyuiu.SosninRA.Sprint2.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }
    }
}
