using Tyuiu.YushkovaES.Sprint4.Task7.V21.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            string value = "425963128528";

            int res = ds.Calculate(n, m, value);
            int wait = 24; // Расчет суммы четных чисел

            Assert.AreEqual(wait, res);

        }
    }
}
