using Tyuiu.MikhailichenkoAI.Sprint4.Task4.V9.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Михайличенко А. И.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко А. И.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5 на 5 элементов. Заполнить значениями с           *");
            Console.WriteLine("* клавиатуры от 1 до 8. Найдите сумму четных элементов массива.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 5;
            int[,] matrix = new int[rows, columns];

            Console.WriteLine($"Введите элементы матрицы {rows}x{columns} (каждое в диапазоне от 1 до 8):");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int inputNum;
                    bool isValid = false;

                    while (!isValid)
                    {
                        Console.Write($"Введите элемент строки {i}, столбца {j}: ");

                        if (int.TryParse(Console.ReadLine(), out inputNum))
                        {
                            if (inputNum >= 1 && inputNum <= 8)
                            {
                                matrix[i, j] = inputNum;
                                isValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Число должно быть от 1 до 8. Повторите ввод.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Введите целое число.");
                        }
                    }
                }
            }

            Console.WriteLine("\nВаша матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(matrix);

            Console.WriteLine($"Сумма четных элементов массива = {res}");

            Console.ReadKey();
        }
    }
}
