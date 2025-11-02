using Tyuiu.YushkovaES.Sprint4.Task4.V8.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                {1, 3, 2, 2, 5},
                {6, 1, 5, 5, 2},
                {1, 5, 4, 1, 4},
                {4, 1, 4, 4, 5},
                {4, 6, 1, 1, 4}
            };

            int[,] res = ds.Calculate(matrix);

            // Ожидаемый результат после замены четных на 1
            int[,] wait = new int[5, 5] {
                {1, 3, 1, 1, 5},
                {1, 1, 5, 5, 1},
                {1, 5, 1, 1, 1},
                {1, 1, 1, 1, 5},
                {1, 1, 1, 1, 1}
            };

            // Проверяем что матрицы равны
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }

            }
        }
    }
}
