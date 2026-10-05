using Tyuiu.MikhailichenkoAI.Sprint4.Task4.V9.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { 3, 7, 3, 1, 5 },
                { 6, 3, 2, 1, 2 },
                { 1, 3, 2, 8, 1 },
                { 5, 8, 1, 5, 1 },
                { 3, 3, 4, 4, 6 }
            };

            int res = ds.Calculate(matrix);

            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}
