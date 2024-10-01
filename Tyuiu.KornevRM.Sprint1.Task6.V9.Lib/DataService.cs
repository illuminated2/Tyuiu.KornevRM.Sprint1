
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KornevRM.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string result = "";
            foreach (string s in value.Split(" ")) {
                List<char> x = new List<char>((s[s.Length - 1] + s).ToCharArray());
                x.RemoveAt(s.Length);
                result += " "+new string(x.ToArray());
            }
            
            return result;
        }
    }
}
