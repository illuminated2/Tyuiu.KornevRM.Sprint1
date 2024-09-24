using Tyuiu.KornevRM.Sprint1.Task0.V24.Lib;
namespace Tyuiu.KornevRM.Sprint1.Task0.V24
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
            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
