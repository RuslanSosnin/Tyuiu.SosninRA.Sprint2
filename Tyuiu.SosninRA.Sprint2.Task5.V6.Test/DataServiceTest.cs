using Tyuiu.SosninRA.Sprint2.Task5.V6.Lib;

namespace Tyuiu.SosninRA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            int m = 1;  // пики
            int k = 12; // дама

            string res = ds.FindCardNameAndValue(m, k);
            string wait = "дама пик";

            Assert.AreEqual(wait, res);
        }
    }
}
