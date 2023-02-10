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
using Task1.Controls;

namespace Task1
{
    public partial class FormMain : Form
    {
        private string[] nameThread = { "Процесс генерации пар чисел", "Процесс сложения пар чисел", "Процесс произведения пар чисел" };
        public FormMain()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(maxNumber: 2000);
            worker.WorkInfo += Worker_WorkInfo;
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(worker.Start);
                threads[i].Name = nameThread[i];
                threads[i].Start(i);
            }
        }

        private void Worker_WorkInfo(string info)
        {
            Action action = () => { listBoxLog.Items.Add(info); };
            this.InvokeEx(action);
        }
    }
}
