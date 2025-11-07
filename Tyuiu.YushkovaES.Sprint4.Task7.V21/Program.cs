using Tyuiu.YushkovaES.Sprint4.Task7.V21.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #21                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int n = 4;
            int m = 3;
            string value = "425963128528";

            Console.WriteLine("n (строки) = " + n);
            Console.WriteLine("m (столбцы) = " + m);
            Console.WriteLine("Строка: " + value);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            int result = ds.Calculate(n, m, value);
            Console.WriteLine("Сумма четных чисел в матрице " + n + "x" + m + " = " + result);


            Console.ReadKey();
        }
    }
}
