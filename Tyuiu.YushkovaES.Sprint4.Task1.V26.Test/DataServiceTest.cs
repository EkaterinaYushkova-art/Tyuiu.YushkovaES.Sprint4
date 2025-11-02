using Tyuiu.YushkovaES.Sprint4.Task1.V26.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };
            int res = ds.Calculate(array);
            int wait = 7 + 7 + 3 + 3 + 3 + 1; // 7+7+3+3+3+1 = 24

            Assert.AreEqual(wait, res);

        }
    }
}
