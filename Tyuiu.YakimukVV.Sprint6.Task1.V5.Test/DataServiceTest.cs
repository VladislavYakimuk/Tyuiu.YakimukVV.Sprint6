using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint6.Task1.V5.Lib;
using System;

namespace Tyuiu.YakimukVV.Sprint6.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFunctionCalculation()
        {
            var dataService = new DataService();

            double[] expected = { 8.04, 6.68, 4.84, 1.76, 0.45, 0.5, -0.87, -2.42, -3.88, -6.83, -8.88 };
            double[] result = dataService.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidRange()
        {
            var dataService = new DataService();
            dataService.GetMassFunction(5, -5); 
        }
    }
}
