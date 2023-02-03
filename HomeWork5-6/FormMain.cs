using System;
using System.Threading;
using System.Windows.Forms;

namespace HomeWork5_6
{
    public partial class FormMain : Form
    {
        MyThread fibinacciThread;
        MyThread primeNumberThread;
        Thread threadState;


        public FormMain()
        {
            InitializeComponent();
            fibinacciThread = new MyThread(FibinacciNumber);
            primeNumberThread = new MyThread(PrimeNumber);
            threadState = new Thread(checkThreadState);
            threadState.IsBackground = true;
            threadState.Start();
        }

        private void textBoxBeginRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)  //цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void checkThreadState()
        {
            while (true)
            {
                if (labelPrimeThreadState.InvokeRequired)
                    labelPrimeThreadState.Invoke(new Action(() =>
                    {
                        labelPrimeThreadState.Text = primeNumberThread?.checkStateString();
                        labelFibinacciThreadState.Text = fibinacciThread?.checkStateString();
                    }));
            }
        }
        private void buttonRunPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Run();       
        private void buttonAbortPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Abort();
        [Obsolete]
        private void buttonSuppentPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Suppent();
        [Obsolete]
        private void buttonResumePrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Resume();
        private void buttonRestartPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Restart();
        private void buttonRunFibinacciNumber_Click(object sender, EventArgs e) => fibinacciThread.Run();
        private void buttonAbortFibinacciNumber_Click(object sender, EventArgs e) => fibinacciThread.Abort();
        [Obsolete]
        private void buttonSuppentFiibinacciNumber_Click(object sender, EventArgs e) => fibinacciThread.Suppent();
        [Obsolete]
        private void buttonResumeFiibinacciNumber_Click(object sender, EventArgs e) => fibinacciThread.Resume();
        private void buttonRestartFibinacciNumber_Click(object sender, EventArgs e) => fibinacciThread.Restart();
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fibinacciThread.checkState() || (primeNumberThread.checkState()))
            {
                MessageBox.Show("Потоки не завершены. Завершите поток");
                e.Cancel = true;
            }
        }
        /************************************Вспомогательные функции************************************/
        private void PrimeNumber()
        {
            bool infinite = false;
            ulong beginRange = 0;
            ulong endRange = 0;
            if (textBoxBeginRange.Text.Length == 0)
                beginRange = 2;
            else
                beginRange = ulong.Parse(textBoxBeginRange.Text);

            if (textBoxEndRange.Text.Length > 0)
                endRange = ulong.Parse(textBoxEndRange.Text);
            else
                infinite = true;
            if (infinite == false)
            {
                if (beginRange > endRange)
                {
                    (beginRange, endRange) = (endRange, beginRange);
                }
            }
            while (infinite == true || beginRange <= endRange)
            {
                if (MyFunctions.checkPrimeNumber(beginRange))
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
        private void FibinacciNumber()
        {
            ulong number = 1;
            ulong counter = 2;
            while (true)
            {
                Thread.Sleep(1000);
                number = MyFunctions.fibonachi(counter);
                Invoke(new Action(() =>
                {
                    listBoxThreadFibinacciNumber.Items.Add(number);
                }));
                counter++;
            }
        }
    }
}
