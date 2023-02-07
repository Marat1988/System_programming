using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.WorkBegin += Worker_WorkBegin;
            worker.WorkEnd += Worker_WorkEnd;
            Thread thread1 = new Thread(worker.Thread1);
            thread1.Name = "Процесс заполнения файла числами";
            thread1.Start();
            Thread thread2 = new Thread(worker.Thread1);
            thread2.Name = "Процесс2 другой";
            thread2.Start();
        }
        private void Worker_WorkBegin(string info)
        {
            Action action = () => { listBoxLog.Items.Add(info); };
            this.InvokeEx(action);
        }
        private void Worker_WorkEnd(string info)
        {
            Action action = () => { listBoxLog.Items.Add(info); };
            this.InvokeEx(action);
        }
    }
}
