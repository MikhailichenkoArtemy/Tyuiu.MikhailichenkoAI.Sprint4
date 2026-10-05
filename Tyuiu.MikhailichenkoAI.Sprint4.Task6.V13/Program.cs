using Tyuiu.MikhailichenkoAI.Sprint4.Task6.V13.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Михайличенко А. И.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Михайличенко А. И.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных. Подсчитайте количество элементов, длина    *");
            Console.WriteLine("* которых больше 4.                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] carsArray = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < carsArray.Length; i++)
            {
                Console.WriteLine($"[{i}] = {carsArray[i]}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(carsArray);

            Console.WriteLine($"Количество элементов с длиной больше 4 символов: {res}");

            Console.ReadKey();
        }
    }
}
