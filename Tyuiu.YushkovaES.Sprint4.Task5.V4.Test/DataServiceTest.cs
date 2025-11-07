using Tyuiu.YushkovaES.Sprint4.Task5.V4.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
        {-3, 2, -4, 5, 0},
        {6, -1, 3, -2, 4},
        {1, -4, 2, 6, -3},
        {0, 3, 5, -2, 1},
        {4, -1, 6, 3, 2}
    };

            int res = ds.Calculate(matrix);
            int wait = 12; // Количество четных элементов

            Assert.AreEqual(wait, res);

        }
    }
}
