using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YushkovaES.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
