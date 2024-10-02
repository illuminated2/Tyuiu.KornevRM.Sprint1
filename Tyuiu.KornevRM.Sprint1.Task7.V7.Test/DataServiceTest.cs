using Tyuiu.KornevRM.Sprint1.Task7.V7.Lib;
namespace Tyuiu.KornevRM.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = -6.642;
            var res = ds.Calculate(x , y);
            Assert.AreEqual(wait, res);


        }
    }
}