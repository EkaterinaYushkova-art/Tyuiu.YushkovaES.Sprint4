using Tyuiu.YushkovaES.Sprint4.Task3.V27.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int[,] array = new int[5, 5] {
                {4, 3, 5, 5, 3},
                {6, 7, 4, 4, 3},
                {3, 3, 7, 3, 6},
                {3, 4, 3, 7, 7},
                {3, 5, 6, 3, 6}
            };

            Console.WriteLine("Массив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Количество четных элементов во всем массиве = " + result);


            Console.ReadKey();




        }
    }
}

