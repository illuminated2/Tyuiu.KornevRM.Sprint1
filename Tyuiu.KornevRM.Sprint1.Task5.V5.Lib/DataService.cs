using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KornevRM.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = x - Math.Floor(x);
            int d = (int)(res * 10);
            return d;

        }
    }
}
