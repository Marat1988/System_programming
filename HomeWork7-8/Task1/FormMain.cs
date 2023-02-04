using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Task1.Controls;

namespace Task1
{
    public partial class FormMain : Form
    {
        private List<Worker> workers = new List<Worker>();
        const int defaultWidth = 670;
        const int defaultHeight = 30;
        const int defaultLocationX = 12;
        const int defaultLocationY = 60;
        const int indent = 10;

        public FormMain()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnStop.Click += BtnStop_Click;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (workers.Count == 0)
            {
                for (int i = 0; i < numericUpDownCountProgressBar.Value; i++)
                {
                    int locationY = (i == 0) ? defaultLocationY : (workers[i - 1].ProgressBar.Location.Y + defaultHeight + indent);
                    workers.Add(new Worker(new MaratProgressBar()
                    {
                        Name = "ProgressBar " + i,
                        Width = defaultWidth,
                        Height = defaultHeight,
                        Location = new Point(defaultLocationX, locationY),
                        ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255))
                    }));
                    workers[i].ProcessChanged += worker_ProcessChanged;
                    workers[i].WorkCompleted += worker_WorkCompleted;
                    this.Controls.Add(workers[i].ProgressBar);
                }
            }
            btnStart.Enabled = false;
            Thread thread = new Thread(delegate ()
            {
                workers[0].Cancelled = false;
                workers[0].Work();
            });
            thread.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e) => workers[0].Cancelled = true;
 
        private void worker_WorkCompleted(bool cancelled)
        {
            Action action = () =>
            {
                MessageBox.Show(cancelled ? "Процесс отменен" : "Процесс завершен");
                btnStart.Enabled = true;
            };
            this.InvokeEx(action);
        }

        private void worker_ProcessChanged(int progress)
        {
            Action action = () => workers.ForEach((Worker worker) => worker.ProgressBar.Value = progress);    
            this.InvokeEx(action);
        }
    }
}
