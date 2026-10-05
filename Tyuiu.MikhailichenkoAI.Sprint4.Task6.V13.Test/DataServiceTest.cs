using Tyuiu.MikhailichenkoAI.Sprint4.Task6.V13.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] carsArray = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            int res = ds.Calculate(carsArray);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
