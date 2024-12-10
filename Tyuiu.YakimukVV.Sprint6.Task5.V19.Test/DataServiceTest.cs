using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint6.Task5.V19.Lib;
using System;
using System.IO;

namespace Tyuiu.YakimukVV.Sprint6.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            var dataService = new DataService();
            string path = @"C:\Users\jetjo\source\repos\InPutFileTask5V19.txt";

            var content = "1 2.35 5\n3 4.4 7.123";
            File.WriteAllText(path, content);

            var result = dataService.LoadFromDataFile(path);

            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2.35, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(3, result[3]);
        }
    }
}
