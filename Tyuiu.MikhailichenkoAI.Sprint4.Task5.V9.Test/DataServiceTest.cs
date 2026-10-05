using Tyuiu.MikhailichenkoAI.Sprint4.Task5.V9.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task5.V9.Test
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
                { -4, -3, -2, -1, 0 }, 
                {  1,  2,  3,  4, 1 }, 
                { -1, -1,  1,  1, 1 }, 
                {  0,  0,  0,  0, 0 }, 
                {  4,  4,  4,  4, 4 }  
            };

            int res = ds.Calculate(matrix);

            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}
