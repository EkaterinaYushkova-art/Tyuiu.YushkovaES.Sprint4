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
        { -3, -4, 3, 4, -2 },
        { -2, 2, 4, -4, 4 },
        { 1, -4, -3, 1, 2 },
        { 2, -3, -1, -4, -3 },
        { -2, -2, 4, 3, -4 } };
        

        


            int res = ds.Calculate(matrix);
            int wait = 11; // 4+3+4+2+3 = 11 четных элементов

            Assert.AreEqual(wait, res);


        }
    }
}
