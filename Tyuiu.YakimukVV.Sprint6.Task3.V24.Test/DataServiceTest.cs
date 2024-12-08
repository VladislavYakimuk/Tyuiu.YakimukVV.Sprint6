using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint6.Task3.V24.Lib;

namespace Tyuiu.YakimukVV.Sprint6.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            var dataService = new DataService();
            int[,] matrix = new int[,]
            {
                { -17, -6, 10, 5, 3 },
                { -10, -14, 10, -7, -3 },
                { -19, 9, 8, -17, -9 },
                { -19, -5, -9, -18, 14 },
                { 17, 12, 11, 12, 2 }
            };
            int[,] expected = new int[,]
            {
                { -17, -6, 10, 5, 3 },
                { 0, 0, 0, -7, -3 },
                { -19, 9, 8, -17, -9 },
                { -19, -5, -9, -18, 14 },
                { 17, 12, 11, 12, 2 }
            };

            var result = dataService.Calculate(matrix);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
