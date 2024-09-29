using Tyuiu.KornevRM.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");


            Console.WriteLine("Введите число X: ");
            double x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

            int d = Convert.ToInt32(ds.Calculate(x));  
                Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
