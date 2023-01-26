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
        [DllImport("User32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    }

    class Program
    {
        const string information = "Тестовое сообщение";
        static void Main(string[] args)
        {
            DllImportExample.MessageBox(IntPtr.Zero, "Тухтаров Марат Ринадович", information, 0);
            DllImportExample.MessageBox(IntPtr.Zero, "Студент компьютерной академии \"ТОП\"", information, 0);
            Console.ReadKey();
        }
    }
}
