using Tyuiu.MikhailichenkoAI.Sprint4.Task3.V30.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Михайличенко А. И.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Михайличенко А. И.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5 на 5 элементов, заполненный статическими         *");
            Console.WriteLine("* значениями. Найдите максимальный элемент в третьей строке массива.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5]
            {
                { 2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6 },
                { 3, 3, 2, 1, 5 }, 
                { 6, 4, 1, 3, 3 },
                { 5, 1, 1, 6, 4 }
            };

            Console.WriteLine("Исходный массив:");
            
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine(); 
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(matrix);

            Console.WriteLine($"Максимальный элемент в третьей строке = {res}");

            Console.ReadKey();
        }
    }
}
