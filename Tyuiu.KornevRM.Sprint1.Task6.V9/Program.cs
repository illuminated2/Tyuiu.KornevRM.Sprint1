using Tyuiu.KornevRM.Sprint1.Task6.V9.Lib;

namespace Tyuiu.KornevRM.Sprint1.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine(ds.MoveLetterToStart(text));

            Console.ReadKey();

            //string[] words = text.Split(' ');

            /*foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    char lastLetter = word[word.Length - 1];
                    string newWord = lastLetter + word.Substring(0, word.Length - 1);
                    Console.WriteLine(newWord);
                }
                else
                {
                    Console.WriteLine(word);
                }
            }*/
        }
    }
}
