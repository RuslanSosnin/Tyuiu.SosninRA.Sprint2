using Tyuiu.SosninRA.Sprint2.Task6.V4.Lib;

namespace Tyuiu.SosninRA.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            DataService ds = new DataService();

            Assert.AreEqual("пики", ds.FindCardSuit(1));
            Assert.AreEqual("трефы", ds.FindCardSuit(2));
            Assert.AreEqual("бубны", ds.FindCardSuit(3));
            Assert.AreEqual("червы", ds.FindCardSuit(4));
        }

        [TestMethod]
        public void InvalidCardSuit()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(5);
            });
        }
    }
}
