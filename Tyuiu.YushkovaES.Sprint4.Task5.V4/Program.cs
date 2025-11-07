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
            


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            int[,] matrix = new int[5, 5] {
        {-4,  2, -4,  5,  0},  // четные: -4, 2, -4, 0 = 4
        { 6, -1,  3, -2,  4},  // четные: 6, -2, 4 = 3
        { 1, -4,  2,  3, -3},  // четные: -4, 2 = 2 (вместо 6 ставим 3)
        { 0,  3,  5, -2,  1},  // четные: 0, -2 = 2
        { 4, -1,  6,  3,  2}   // четные: 4, 6, 2 = 3
    };


            int result = ds.Calculate(matrix);
            Console.WriteLine("Количество четных элементов в матрице = " + result);

            Console.ReadKey();


           
        }
    }
}
