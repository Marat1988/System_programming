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

namespace Task1
{
    public partial class FormMain : Form
    {
        Random random = new Random();
        Semaphore sem = new Semaphore(3, 3);

        public FormMain()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;

        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(GenerateNumber);
                threads[i].Name = "Поток " + i;
                threads[i].Start();
            }
        }

        private void GenerateNumber()
        {
            sem.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                int number = random.Next(1, 100);
                if (listBoxNumber.InvokeRequired)
                {
                    listBoxNumber.Invoke(new Action<int>((threadId) => listBoxNumber.Items.Add($"Id потока: {threadId}. Число {number}")), Thread.CurrentThread.ManagedThreadId);
                }               
            }
            sem.Release();
        }
    }
}
