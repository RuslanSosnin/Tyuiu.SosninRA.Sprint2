using Tyuiu.SosninRA.Sprint2.Task7.V9.Lib;

namespace Tyuiu.SosninRA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка внутри области: x = pi/2 (~1.57), y = 0.3
            // sin(pi/2) = 1.0 >= 0.3 и 0 <= 0.3 <= 0.5
            double x = Math.PI / 2;
            double y = 0.3;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void InvalidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка выше границы y = 0.5
            double x = Math.PI / 2;
            double y = 0.8;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(false, res);
        }
    }
}