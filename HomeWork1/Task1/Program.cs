using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функцию MessageBox из Windows API.
 * Отобразите с помощью MessageBox информацию о вас. Данные должны быть показаны в нескольких MessageBox.*/
namespace Task1
{

    public class DllImportExample
    {
        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern int MessageBoxA(IntPtr hWnd, string text, string caption, uint type);
    }

    class Program
    {
        const string information = "Тестовой сообщение";
        static void Main(string[] args)
        {
            DllImportExample.MessageBoxA(IntPtr.Zero, "Тухтаров Марат Ринадович", information, 0);
            DllImportExample.MessageBoxA(IntPtr.Zero, "Студент компьютерной академии \"ТОП\"", information, 0);
            Console.ReadKey();
        }
    }
}
