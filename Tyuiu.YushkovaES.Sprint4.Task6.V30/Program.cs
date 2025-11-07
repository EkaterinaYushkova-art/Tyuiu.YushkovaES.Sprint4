using Tyuiu.YushkovaES.Sprint4.Task6.V30.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Класс Array                                                      *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string[] array = { "Береза", "Дуб", "Клен", "Сосна", "Тахта", "Осина" };

            Console.WriteLine("Исходный массив:");
            foreach (string str in array)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string[] result = ds.Calculate(array);
            Console.WriteLine("Элементы массива, длина которых больше 5 символов:");

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }



            Console.ReadKey();
        }
    }
}
