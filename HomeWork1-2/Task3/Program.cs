using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Task2
{
    /*Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функции
     * Beep и MessageBeep из Windows API. С помощью импортированных функций сгенерируйте набор звуковых
     * сигналов через определенные промежутки времени.*/
    public class DllImportExample
    {
        [DllImport("Kernel32.dll")]
        public static extern int Beep(uint dwFreq, uint dwDuration);
        [DllImport("User32.dll")]
        public static extern bool MessageBeep(uint type);
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (DllImportExample.MessageBeep(0x40))
            {
                Console.WriteLine("Вруби побольше звук!");
                Thread.Sleep(5000);
                DllImportExample.Beep(750, 2000);
                DllImportExample.Beep(1000, 2000);
                DllImportExample.Beep(1500, 2000);
            }
            DllImportExample.Beep(2000, 3000);
        }
    }
}
