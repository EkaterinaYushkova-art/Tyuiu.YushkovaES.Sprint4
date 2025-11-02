using Tyuiu.YushkovaES.Sprint4.Task0.V5.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (статистический ввод)                         *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();







            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int result = ds.GetSumEvenArrEl(array);
            Console.WriteLine("Сумма четных элементов массива = " + result);

            Console.ReadKey();


           

        }
    }
}