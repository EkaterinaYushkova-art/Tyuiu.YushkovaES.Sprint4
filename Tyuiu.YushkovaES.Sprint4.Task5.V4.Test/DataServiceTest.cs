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

            // ТА ЖЕ САМАЯ фиксированная матрица
            int[,] matrix = new int[5, 5] {
    {-4,  2, -3,  5,  0},  // четные: -4, 2, 0 = 3
    { 6, -1,  3, -2,  4},  // четные: 6, -2, 4 = 3
    { 1, -4,  2,  6, -3},  // четные: -4, 2, 6 = 3
    { 0,  3,  5, -2,  1},  // четные: 0, -2 = 2
    { 4, -1,  6,  3,  2}   // четные: 4, 6, 2 = 3
};


            int res = ds.Calculate(matrix);
            int wait = 14; // 4+3+4+2+3 = 14 четных элементов

            Assert.AreEqual(wait, res);


        }
    }
}
