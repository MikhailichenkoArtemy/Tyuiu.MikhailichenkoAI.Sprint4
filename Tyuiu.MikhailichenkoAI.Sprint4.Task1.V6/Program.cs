using Tyuiu.MikhailichenkoAI.Sprint4.Task1.V6.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint4.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Михайличенко А. И. | ИИПБ26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко А. И.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив на 10 элементов. Заполнить с клавиатуры значениями от 2 до 7 *");
            Console.WriteLine("* и подсчитать произведение четных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 10;
            int[] numsArray = new int[len];

            Console.WriteLine($"Введите {len} чисел (каждое в диапазоне от 2 до 7):");

            for (int i = 0; i < len; i++)
            {
                int inputNum;
                bool isValid = false;

                while (!isValid)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    
                    if (int.TryParse(Console.ReadLine(), out inputNum))
                    {
                        if (inputNum >= 2 && inputNum <= 7)
                        {
                            numsArray[i] = inputNum;
                            isValid = true; 
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Число должно быть от 2 до 7. Повторите ввод.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите целое число.");
                    }
                }
            }

            Console.WriteLine("\nВаш массив: ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine($"Произведение четных элементов массива = {res}");

            Console.ReadKey();
        }
    }
}
