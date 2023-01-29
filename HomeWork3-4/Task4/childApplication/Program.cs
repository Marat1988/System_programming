using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace childApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string textFile = File.ReadAllText(args[0]);
                Regex REX = new Regex(args[1], RegexOptions.IgnoreCase);
                MatchCollection RTQ = REX.Matches(textFile);
                Console.WriteLine($"Заданное слово {args[1]} встречается в файле {args[0]} {RTQ.Count} раз");
            }
            Console.WriteLine("Для выхода жми любую клавишу......");
            Console.ReadKey();
        }
    }
}
