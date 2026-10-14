using Tyuiu.SosninRA.Sprint2.Task3.V6.Lib;

namespace Tyuiu.SosninRA.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            // 4 + ((4 - 15)/(4 - 10))^(4 - 3) = 4 + (-11 / -6)^1 = 4 + 1.8333... = 5.833
            double res = ds.Calculate(x);
            Assert.AreEqual(5.833, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            // (0 - cos(0) + 10) / (0 - sin(0) + 12) = (-1 + 10) / 12 = 9 / 12 = 0.75
            double res = ds.Calculate(x);
            Assert.AreEqual(0.75, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            // (1 + 1)^(-1) = 2^(-1) = 0.5
            double res = ds.Calculate(x);
            Assert.AreEqual(0.5, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -11;
            // -11 - 110 - (1 / -11) = -121 + 0.0909... = -120.909
            double res = ds.Calculate(x);
            Assert.AreEqual(-120.909, res);
        }
    }
}
