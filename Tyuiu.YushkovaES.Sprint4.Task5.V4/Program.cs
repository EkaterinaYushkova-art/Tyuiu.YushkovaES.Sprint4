using Tyuiu.YushkovaES.Sprint4.Task5.V4.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #4                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Random random = new Random();
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Матрица 5x5 (случайные значения от -4 до 6):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-4, 7);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }

                Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
                int result = ds.Calculate(matrix); // Теперь возвращает int
                Console.WriteLine("Количество четных элементов в матрице = " + result);

                Console.ReadKey();



                Console.ReadKey();
        }
    }
}
