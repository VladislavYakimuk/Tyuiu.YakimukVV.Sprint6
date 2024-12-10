using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint6.Task4.V14.Lib;

namespace Tyuiu.YakimukVV.Sprint6.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            double[] result = dataService.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);
            Assert.AreEqual(0, result[5]); 
        }
    }
}
