namespace Tyuiu.YakimukVV.Sprint6.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new Tyuiu.YakimukVV.Sprint6.Task0.V21.Lib.DataService();
            int x = 2;
            double expected = 13; 

            double actual = service.Calculate(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
