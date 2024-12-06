using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint6.Task2.V21.Lib;

namespace Tyuiu.YakimukVV.Sprint6.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();

            double[] expected = { -16.48, -14.04, -11.62, -9.2, -6.8, -4.42, -2.05, 0.28, 2.57, 4.83, 7.06 };
            double[] actual = dataService.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
