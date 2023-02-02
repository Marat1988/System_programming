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
        public FormMain()
        {
            InitializeComponent();
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
            if ((threadPrimeNumber == null) || (threadPrimeNumber.ThreadState == ThreadState.Aborted))
            {
                //Простые числа
                threadPrimeNumber = new Thread(PrimeNumber);
                threadPrimeNumber.Start();
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

            while (infinite == true || Math.Min(beginRange, endRange) <= Math.Max(beginRange, endRange))
            {
                if (checkPrimeNumber(beginRange))
                {
                    Thread.Sleep(1000);
                    listBoxThreadPrimeNumber.Invoke(new Action(() =>
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
            if (checkStateForSuppendAbortThread(ref threadPrimeNumber))
                threadPrimeNumber?.Abort();
        }
        //Приостановка потока
        [Obsolete]
        private void buttonSuppentPrimeNumber_Click(object sender, EventArgs e)
        {
            if (checkStateForSuppendAbortThread(ref threadPrimeNumber))
                threadPrimeNumber?.Suspend();
        }
        //Возобновление работы потока
        [Obsolete]
        private void buttonResumePrimeNumber_Click(object sender, EventArgs e)
        {
            if (threadPrimeNumber?.ThreadState == ThreadState.Suspended)
                threadPrimeNumber?.Resume();
        }
        /************************************Числа Фибоначчи************************************/
        //Запуск потока или перезапуска потока
        private void buttonRunFibinacciNumber_Click(object sender, EventArgs e)
        {
            if ((threadFibinacciNumber == null) || (threadFibinacciNumber.ThreadState == ThreadState.Aborted))
            {
                //Числа фибиначчи
                threadFibinacciNumber = new Thread(FibinacciNumber);
                threadFibinacciNumber.Start();
            }
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
                listBoxThreadFibinacciNumber.Invoke(new Action(() =>
                {
                    listBoxThreadFibinacciNumber.Items.Add(number);
                }));
                counter++;
            }
        }
        //Остановка потока
        private void buttonAbortFibinacciNumber_Click(object sender, EventArgs e)
        {
            if (checkStateForSuppendAbortThread(ref threadFibinacciNumber))
                threadFibinacciNumber?.Abort();           
        }
        //Приостановка потока
        [Obsolete]
        private void buttonSuppentFiibinacciNumber_Click(object sender, EventArgs e)
        {
            if (checkStateForSuppendAbortThread(ref threadFibinacciNumber))
                threadFibinacciNumber?.Suspend();
        }
        //Возобновление работы потока
        [Obsolete]
        private void buttonResumeFiibinacciNumber_Click(object sender, EventArgs e)
        {
            if (threadFibinacciNumber?.ThreadState == ThreadState.Suspended)
                threadFibinacciNumber?.Resume();
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
        //Функция проверки состояния потока для завершения (abort) или приостановки (Suspend) потока
        private bool checkStateForSuppendAbortThread(ref Thread thread)
        {
            return (thread?.ThreadState == ThreadState.WaitSleepJoin || thread?.ThreadState == ThreadState.Running);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((threadPrimeNumber != null || threadFibinacciNumber != null) && (checkStateForSuppendAbortThread(ref threadPrimeNumber) || checkStateForSuppendAbortThread(ref threadFibinacciNumber)))
            {
                MessageBox.Show("Потоки не завершены. Завершите поток");
                e.Cancel = true;
            }
        }
    }
}
