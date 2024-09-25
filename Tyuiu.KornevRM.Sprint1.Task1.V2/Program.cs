using Tyuiu.KornevRM.Sprint1.Task1.V2.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | выполнил: Корнев Р. М. | ИСПб-24-1";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #0                                                           *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                         *");
            Console.WriteLine("* Задание #7                                                          *");
            Console.WriteLine("* Вариант #0                                                          *");
            Console.WriteLine("* Выполнил: Корнев Руслан Максимович  |  ИСПб-24-1                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать консольную программу на С#, Которая суммирует значение двух*");
            Console.WriteLine("* одинаковых массивов по длинне.                                      *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine(ds.Calculate(x , y));
            Console.ReadKey();
        }
    }
}
