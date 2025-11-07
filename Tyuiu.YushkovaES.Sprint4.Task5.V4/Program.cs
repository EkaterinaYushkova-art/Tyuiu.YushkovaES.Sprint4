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
            int startValue = -4;
            int stopValue = 6;
            Console.WriteLine("Диапазон значений: от " + startValue + " до " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            int[,] matrix = new int[5, 5] {
                {-4,  2, -3,  5,  0},
                { 6, -1,  3, -2,  4},
                { 1, -4,  2,  6, -3},
                { 0,  3,  5, -2,  1},
                { 4, -1,  6,  3,  2}
            };

            int result = ds.Calculate(matrix);
            Console.WriteLine("Количество четных элементов в матрице = " + result);

            Console.ReadKey();


           
        }
    }
}
