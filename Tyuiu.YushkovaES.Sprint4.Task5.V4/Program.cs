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
         { 3, 4, 3, 4, 2 },
        { -2, 2, 4, -4, 4 },
        { 1, -4, -3, 1, 2 },
        { 2, -3, -1, -4, -3 },
        { -2, -2, 4, 3, -4 } };



            int result = ds.Calculate(matrix);
            Console.WriteLine("Количество четных элементов в матрице = " + result);

            Console.ReadKey();


           
        }
    }
}
