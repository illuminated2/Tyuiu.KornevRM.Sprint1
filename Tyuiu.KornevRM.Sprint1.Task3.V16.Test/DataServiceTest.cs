using Tyuiu.KornevRM.Sprint1.Task3.V16.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = -2.000;
            var res = ds.CoeffOfQuadraticEquation(x , y);
            Assert.AreEqual(wait, res);

        }
    }
}