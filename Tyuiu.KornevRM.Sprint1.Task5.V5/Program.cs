using Tyuiu.KornevRM.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task5.V5
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Корнев Р.М.  | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части положительного");
            Console.WriteLine("* числа x(так, если x = 32.597, то d = 5)                                 *");
            Console.WriteLine("* с помощью класса Convert.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


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
