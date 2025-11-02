using Tyuiu.YushkovaES.Sprint4.Task2.V25.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                         *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #25                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Random random = new Random();
            int[] array = new int[11];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(3, 10); // от 3 до 9 включительно
                Console.Write(array[i] + " ");
            }


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Произведение четных элементов массива = " + result);

            Console.ReadKey();




        }
    }
}

