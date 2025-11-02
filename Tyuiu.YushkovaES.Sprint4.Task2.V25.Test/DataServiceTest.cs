using Tyuiu.YushkovaES.Sprint4.Task2.V25.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Пример массива для теста
            int[] array = { 4, 5, 6, 7, 8, 3, 4, 9, 6, 5, 8 };
            int res = ds.Calculate(array);

            // Четные элементы: 4, 6, 8, 4, 6, 8
            // Произведение: 4 * 6 * 8 * 4 * 6 * 8 = 36864
            int wait = 4 * 6 * 8 * 4 * 6 * 8;

            Assert.AreEqual(wait, res);

        }
    }
}
