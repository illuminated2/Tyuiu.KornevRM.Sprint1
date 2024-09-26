using Tyuiu.KornevRM.Sprint1.Task2.V23.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
            int x;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine("Время в секундах = " + ds.ConvertMinutesToSeconds(x));
            Console.ReadLine();

        }
    }
}
