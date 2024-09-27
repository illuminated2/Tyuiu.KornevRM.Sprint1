using Tyuiu.KornevRM.Sprint1.Task3.V16.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            
           
            Console.Write("Введите первый корень (x1): ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второй корень (x2): ");
            double x2 = Convert.ToDouble(Console.ReadLine());

           
            double b = -(x1 + x2);

            
            Console.WriteLine($"Коэффициент b = {b:F3}");
            Console.ReadKey();

        }
    }
}
