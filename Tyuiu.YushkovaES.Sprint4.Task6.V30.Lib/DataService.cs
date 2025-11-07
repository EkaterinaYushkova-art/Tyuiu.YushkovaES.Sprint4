using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YushkovaES.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            int count = 0;
            foreach (string str in array)
            {
                if (str.Length > 5) // БОЛЬШЕ 5, значит от 6 и выше
                {
                    count++;
                }
            }

            // Создаем новый массив только с подходящими элементами
            string[] result = new string[count];
            int index = 0;

            foreach (string str in array)
            {
                if (str.Length > 5)
                {
                    result[index] = str;
                    index++;
                }
            }

            return result;

        }
    }
}
