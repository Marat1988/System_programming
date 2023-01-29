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
                Regex regex = new Regex(args[1], RegexOptions.IgnoreCase);
                string textFile = File.ReadAllText(args[0]);
                string[] mas = textFile.Split(' ');
                int count = mas.Where(word => regex.IsMatch("Привет")).Count();
                Console.WriteLine($"Заданное слово {args[1]} встречается в файле {args[0]} {count} раз");
            }           
            Console.WriteLine("Для выхода жми любую клавишу......");
            Console.ReadKey();
        }
    }
}
