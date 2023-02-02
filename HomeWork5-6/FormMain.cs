using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork5_6
{
    public partial class FormMain : Form
    {
        Thread threadPrimeNumber;
        Thread threadFibinacciNumber;
        MyThread fibinacci;

        public FormMain()
        {
            InitializeComponent();
            fibinacci = new MyThread(FibinacciNumber);
        }


        private void textBoxBeginRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)  //цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        /************************************Простые числа************************************/
        //Запуск потока или перезапуска потока
        private void buttonRunPrimeNumber_Click(object sender, EventArgs e)
        {
            if ((threadPrimeNumber == null) || (threadPrimeNumber.ThreadState == ThreadState.Aborted)
                || (threadPrimeNumber.ThreadState == ThreadState.Stopped))
            {             
                //Простые числа
                threadPrimeNumber = new Thread(PrimeNumber);
                threadPrimeNumber?.Start();
            }
        }
        //Простые числа
        private void PrimeNumber()
        {
            bool infinite = false;
            ulong beginRange = 0;
            ulong endRange = 0;
            if (textBoxBeginRange.Text.Length==0)
                beginRange = 2;
            else
                beginRange = ulong.Parse(textBoxBeginRange.Text);

            if (textBoxEndRange.Text.Length > 0)
                endRange = ulong.Parse(textBoxEndRange.Text);
            else
                infinite = true;
            beginRange = Math.Min(beginRange, endRange);
            endRange = Math.Max(beginRange, endRange);
            while (infinite == true || beginRange <= endRange)
            {
                if (checkPrimeNumber(beginRange))
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        listBoxThreadPrimeNumber.Items.Add(beginRange);
                    }));

                }
                beginRange++;
            }
        }
        //Остановка потока
        private void buttonAbortPrimeNumber_Click(object sender, EventArgs e)
        {
            if (threadPrimeNumber?.IsAlive == true)
                threadPrimeNumber?.Abort();
        }
        //Приостановка потока
        [Obsolete]
        private void buttonSuppentPrimeNumber_Click(object sender, EventArgs e)
        {
            if (threadPrimeNumber?.IsAlive == true)
                threadPrimeNumber?.Suspend();
        }
        //Возобновление работы потока
        [Obsolete]
        private void buttonResumePrimeNumber_Click(object sender, EventArgs e)
        {
            if (threadPrimeNumber?.ThreadState == ThreadState.Suspended)
                threadPrimeNumber?.Resume();
        }
        //Рестарт потока
        private void buttonRestartPrimeNumber_Click(object sender, EventArgs e)
        {
            if (threadPrimeNumber?.ThreadState != ThreadState.Suspended)
            {
                buttonAbortPrimeNumber_Click(sender, e); //Вырубаем топок
                buttonRunPrimeNumber_Click(sender, e); //Перезапускаем поток
            }
        }


        /************************************Числа Фибоначчи************************************/
        //Запуск потока или перезапуска потока
        private void buttonRunFibinacciNumber_Click(object sender, EventArgs e)
        {
            /*if ((threadFibinacciNumber == null) || (threadFibinacciNumber.ThreadState == ThreadState.Aborted)
                || (threadFibinacciNumber.ThreadState == ThreadState.Running))
            {
                //Числа фибиначчи
                threadFibinacciNumber = new Thread(FibinacciNumber);
                threadFibinacciNumber.Start();
            }*/
            fibinacci.Run();

        }
        //Числа Фибоначчи
        private void FibinacciNumber()
        {
            ulong number = 1;
            ulong counter = 2;
            while (true)
            {
                Thread.Sleep(1000);
                number = Fibonachi(counter);
                Invoke(new Action(() =>
                {
                    listBoxThreadFibinacciNumber.Items.Add(number);
                }));
                counter++;
            }
        }
        //Остановка потока
        private void buttonAbortFibinacciNumber_Click(object sender, EventArgs e)
        {
            /*if (threadFibinacciNumber?.IsAlive == true)
                threadFibinacciNumber?.Abort();           */
            fibinacci.Abort();
        }
        //Приостановка потока
        [Obsolete]
        private void buttonSuppentFiibinacciNumber_Click(object sender, EventArgs e)
        {
            /*if (threadFibinacciNumber?.IsAlive == true)
                threadFibinacciNumber?.Suspend();*/
            fibinacci.Suppent();
        }
        //Возобновление работы потока
        [Obsolete]
        private void buttonResumeFiibinacciNumber_Click(object sender, EventArgs e)
        {
            /*if (threadFibinacciNumber?.ThreadState == ThreadState.Suspended)
                threadFibinacciNumber?.Resume();*/
            fibinacci.Resume();
        }
        //Рестарт потока
        private void buttonRestartFibinacciNumber_Click(object sender, EventArgs e)
        {
            /*if (threadFibinacciNumber?.ThreadState != ThreadState.Suspended)
            {
                buttonAbortFibinacciNumber_Click(sender, e); //Вырубаем поток
                buttonRunFibinacciNumber_Click(sender, e); //Закускаем потока
            }*/
            fibinacci.Restart();
        }



        /************************************Вспомогательные функции************************************/
        //Функция числа Фибоначчи
        private ulong Fibonachi(ulong n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        //Функция проверки является ли число простым
        private bool checkPrimeNumber(ulong number)
        {
            if (number < 2)
                throw new ArgumentException("Число должно быть больше либо равно 2");
            for (ulong i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
  /*          if ((threadPrimeNumber != null || threadFibinacciNumber != null) && (threadPrimeNumber?.IsAlive==true || threadFibinacciNumber?.IsAlive==true))
            {
                MessageBox.Show("Потоки не завершены. Завершите поток");
                e.Cancel = true;
            }*/
        }
    }
}
