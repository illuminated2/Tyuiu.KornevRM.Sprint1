
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KornevRM.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            List<char> x = new List<char>((value[value.Length - 1] + value).ToCharArray());
            x.RemoveAt(value.Length);
            return new string(x.ToArray());
        }
    }
}
