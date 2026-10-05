using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int rowIndex = 2;
            int columnsCount = array.GetLength(1); 

            int maxElement = array[rowIndex, 0];

            for (int j = 1; j < columnsCount; j++)
            {
                if (array[rowIndex, j] > maxElement)
                {
                    maxElement = array[rowIndex, j];
                }
            }

            return maxElement;
        }
    }
}
