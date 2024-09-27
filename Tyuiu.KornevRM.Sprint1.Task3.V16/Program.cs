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


            
            Console.Write("Enter the first root: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second root: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            
            double b = -x1 - x2;

           
            Console.WriteLine("The coefficient b is: {0:F3}", b);
            Console.ReadKey();

        }
    }
}
