using Tyuiu.KornevRM.Sprint1.Task4.V29.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}