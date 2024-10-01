
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KornevRM.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string result = "";
            foreach (string s in value.Split(" ")) {
                string ss = s[s.Length - 1] + s;
                ss.Substring(0, ss.Length - 1);
                result += ss+" ";
            }
            result.Substring(0, result.Length-1);
            return result;
        }
    }
}
