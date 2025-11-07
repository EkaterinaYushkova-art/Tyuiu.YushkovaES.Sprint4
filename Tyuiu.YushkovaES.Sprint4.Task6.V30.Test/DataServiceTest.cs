using Tyuiu.YushkovaES.Sprint4.Task6.V30.Lib;
namespace Tyuiu.YushkovaES.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Береза", "Дуб", "Клен", "Сосна", "Тахта", "Осина" };
            string[] res = ds.Calculate(array);

            string[] wait = { "Береза", "Сосна", "Тахта", "Осина" };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
