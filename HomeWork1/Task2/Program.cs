using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
     /*Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функции
     * FindWindow (поиск окна в системе), SendMessage (отсылка сообщений) из Windows API. Приложение должно произвести поиск окна вашего оконного приложения (можно
     * реализовать его с помощью Windows Forms и т.д.). Если окно найдено необходимо послать ему сообщение в зависимости от выбора пользователя:
     * ■ об изменении заголовка окна на заголовок, введенный пользователем о закрытии окна;
     * ■ ваш вариант.*/
    public class TestApi
    {
        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, StringBuilder lParam);
    }
    class Program
    {
        const string app = "Марат. Тестовое приложение";
        delegate void Handler(IntPtr child);
        static event Handler start;
        static void Main(string[] args)
        {
            try
            {
                start += TestApp;
                Console.Title = "Тест api-функций FindWindow и SendMessage";
                Process p = Process.Start("TestApplication.exe");
                Console.WriteLine("Для продолжения нажмите любую клавишу......");
                Console.ReadKey();
                IntPtr child = TestApi.FindWindow(null, app);
                if (child == IntPtr.Zero)
                {
                    Console.WriteLine("Тестовое приложение не найдено. Продолжение не возможно!");
                }
                else
                {
                    start?.Invoke(child);
                }
            }
            catch (Win32Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        public static void TestApp(IntPtr child)
        {
            uint WM_SETTEXT = 0x000C;
            uint WM_SYSCOMMAND = 0x0112;
            uint SC_CLOSE = 0xF060;
            Console.WriteLine("Введите:\n1 - для закрытия окна дочернего приложения;\n2 - для изменения заголовка окна дочернего приложения;\n3 - для выхода.");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int chooseUser))
                {
                    if (chooseUser == 3)
                        break;
                    switch (chooseUser)
                    {
                        case 1: TestApi.SendMessage(child, WM_SYSCOMMAND, SC_CLOSE, null);
                            break;
                        case 2:
                            Console.Write("Введите сообщение: ");
                            StringBuilder stringBuilder = new StringBuilder();
                            stringBuilder.Append(Console.ReadLine());                    
                            TestApi.SendMessage(child, WM_SETTEXT, 0, stringBuilder);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Не корректно набранная команда");
                }
            }
        }
    }
}
