using Tyuiu.KornevRM.Sprint1.Task3.V16.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Корнев Р.М.  | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р.М.  | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет и печатает коэффициент            *");
            Console.WriteLine("* приведенного квадратного уравнения, корнями которого являются введенные *");
            Console.WriteLine("* пользователем два вещественных числа (для справки: b=-x1-x2).           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


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
