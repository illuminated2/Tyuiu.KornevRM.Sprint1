using Tyuiu.KornevRM.Sprint1.Task4.V29.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine("Результат : " + ds.Calculate(x, y));
            Console.ReadKey();

        }
    }
}
