using Tyuiu.KornevRM.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            var res = ds.Calculate(x);

            int result = Convert.ToInt32(res);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}