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

        private void buttonRunThread_Click(object sender, EventArgs e)
        {
            //Простые числа
            Thread threadPrimeNumber = new Thread(PrimeNumber);
            threadPrimeNumber.IsBackground = true;
            threadPrimeNumber.Start();
            //Числа фибиначчи
            Thread threadFibinacciNumber = new Thread(FibinacciNumber);
            threadFibinacciNumber.IsBackground = true;
            threadFibinacciNumber.Start();
        }

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
                Thread.Sleep(1000);
                if (checkPrimeNumber(beginRange))
                {
                    listBoxThread1.Invoke(new Action(() =>
                    {
                        listBoxThread1.Items.Add(beginRange);
                    }));
                }
                beginRange++;
            }
        }
        private void FibinacciNumber()
        {
            ulong number = 1;
            ulong counter = 2;
            while (true)
            {
                Thread.Sleep(1000);
                number = Fibonachi(counter);
                listBoxThread2.Invoke(new Action(() =>
                {
                    listBoxThread2.Items.Add(number);
                }));
                counter++;
            }
        }

        private ulong Fibonachi(ulong n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

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
    }
}
