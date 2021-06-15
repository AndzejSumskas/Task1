using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Andzej\Desktop\IT Tasks\HomeWork\Task1\Test.txt");

            char[] separators = new char[] { ' ', '.', '?', ',', '-', '\t', '\n', '\r' };

            string[] wordsArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Is viso yra {0} zodziu", wordsArray.Length);

            List<string> wordsList = new List<string>();
            List<int> wordsListCount = new List<int>();

            var result = wordsArray.GroupBy(x => x)
                       .ToDictionary(y => y.Key, y => y.Count())
                       .OrderByDescending(z => z.Value);

            foreach (var x in result)
            {
                Console.WriteLine("Value: " + x.Key + " Count: " + x.Value);
            }

        }
    }
}
