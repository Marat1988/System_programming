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
            ThreadStart threadStart1 = new ThreadStart(thread1);
            Thread threadNumber1 = new Thread(threadStart1);
            threadNumber1.Start();
        }

        private void thread1()
        {
            int beginRange = int.Parse(textBoxBeginRange.Text);
            int endRange = int.Parse(textBoxEndRange.Text);
            for (int i = beginRange; i < endRange; i++)
            {
                if (checkPrimeNumber(i))
                {
                    listBoxThread1.Invoke(new Action(() =>
                    {
                        listBoxThread1.Items.Add(i);
                    }));               
                }
            }
        }

        /// <summary>
        /// Функция, которая проверяет, является ли число простым
        /// </summary>
        /// <param name="number">Вводимое число</param>
        /// <returns>ИСТИНА, если число простое. В противном случае ЛОЖЬ</returns>
        private bool checkPrimeNumber(int number)
        {
            if (number < 2)
                throw new ArgumentException("Число должно быть больше либо равно 2");
            for (int i = 2; i < number; i++)
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
