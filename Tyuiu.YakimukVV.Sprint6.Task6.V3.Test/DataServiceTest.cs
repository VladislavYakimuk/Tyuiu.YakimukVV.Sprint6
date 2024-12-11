using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint6.Task6.V3.Lib;

namespace Tyuiu.YakimukVV.Sprint6.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_ValidFile_ReturnsWordsWithR()
        {
            // Arrange
            var service = new DataService();
            var testFilePath = "testFile.txt";
            File.WriteAllText(testFilePath, "apple orange rabbit rocket");

            // Act
            var result = service.CollectTextFromFile(testFilePath);

            // Assert
            Assert.AreEqual("orange rabbit rocket", result);

            // Cleanup
            File.Delete(testFilePath);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void CollectTextFromFile_NonExistentFile_ThrowsException()
        {
            var service = new DataService();
            service.CollectTextFromFile("nonexistent.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CollectTextFromFile_NullPath_ThrowsException()
        {
            var service = new DataService();
            service.CollectTextFromFile(null);
        }
    }
}
