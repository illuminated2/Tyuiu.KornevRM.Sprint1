using Tyuiu.KornevRM.Sprint1.Task6.V9.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello world";
            DataService ds = new DataService();
            string res = MoveLetterToStart(strTest);
            string wait = "";
            Assert.AreEqual(wait, res);

        }
    }
}