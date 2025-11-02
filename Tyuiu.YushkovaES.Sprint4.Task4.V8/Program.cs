using Tyuiu.YushkovaES.Sprint4.Task4.V8.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task4.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int[,] matrix = new int[5, 5] {
                {1, 3, 2, 2, 5},
                {6, 1, 5, 5, 2},
                {1, 5, 4, 1, 4},
                {4, 1, 4, 4, 5},
                {4, 6, 1, 1, 4}
            };

            Console.WriteLine("Исходная матрица 5x5:");
            PrintMatrix(matrix);




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int[,] resultMatrix = ds.Calculate(matrix);
            Console.WriteLine("Матрица после замены четных элементов на 1:");
            PrintMatrix(resultMatrix);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.ReadKey();
            }
            static void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();





                }
            }
        }
    }
}

