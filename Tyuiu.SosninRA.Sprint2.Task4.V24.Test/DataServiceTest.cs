using Tyuiu.SosninRA.Sprint2.Task4.V24.Lib;

namespace Tyuiu.SosninRA.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 30;
            double y = 1;
            // 30 + 2 > 1 + 24 => 32 > 25 (true)
            // z = 30 * ((1 + 1) / (30 + 2))^30 = 30 * (2/32)^30 = 30 * (1/16)^30 ≈ 0
            double res = ds.Calculate(x, y);
            double wait = 0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 0;
            // 0 + 2 > 0 + 24 => 2 > 24 (false)
            // z = (0^2 + cos(0)^2 + 9) / (0^2 - sin(0)^2 + 12) = (0 + 1 + 9) / (0 - 0 + 12) = 10 / 12 = 0.8333...
            double res = ds.Calculate(x, y);
            double wait = 0.833;

            Assert.AreEqual(wait, res);
        }
    }
}
