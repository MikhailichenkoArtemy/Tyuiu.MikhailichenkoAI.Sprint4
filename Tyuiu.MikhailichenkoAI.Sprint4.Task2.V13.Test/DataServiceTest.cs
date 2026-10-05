using Tyuiu.MikhailichenkoAI.Sprint4.Task2.V13.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6 };

            int res = ds.Calculate(numsArray);

            int wait = 18432;

            Assert.AreEqual(wait, res);
        }
    }
}
