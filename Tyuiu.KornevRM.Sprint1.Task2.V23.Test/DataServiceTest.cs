using Tyuiu.KornevRM.Sprint1.Task2.V23.Lib;


namespace Tyuiu.KornevRM.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMinutesToSeconds(x);
            Assert.AreEqual(4, res);
        }
    }
}