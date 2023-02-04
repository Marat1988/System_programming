using System;
using System.Threading;
using Task1.Controls;

namespace Task1
{
    public class Worker
    {
        public bool Cancelled { get; set; } = false;
        public MaratProgressBar ProgressBar { get; }

        public Worker(MaratProgressBar progressBar)
        {
            this.ProgressBar = progressBar;
        }
        public void Work()
        {
            for (int i = 0; i <= ProgressBar.Maximum; i++)
            {
                if (Cancelled)
                    break;
                Thread.Sleep(50);
                ProcessChanged(i);
            }
            WorkCompleted(Cancelled);
        }

        public event Action<int> ProcessChanged;

        public event Action<bool> WorkCompleted;
    }
}
