using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const int maxCountCopy = 3;
            /*Первый способ*/
            /*using (var sem = new Semaphore(maxCountCopy, maxCountCopy, "Marat"))
            {
                if (sem.WaitOne(TimeSpan.FromSeconds(3)))
                {

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain());
                }
                else
                    MessageBox.Show($"Превышено максимально допустимое число копий приложения", "Гребанный семафор", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            /*Второй способ*/
            if (Process.GetProcessesByName(Application.ProductName).Length > maxCountCopy)
            {
                MessageBox.Show($"Превышено максимально допустимое число копий приложения", "Процесс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
