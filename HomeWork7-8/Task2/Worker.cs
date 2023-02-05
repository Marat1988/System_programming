using System;
using System.Threading;
using System.Windows.Forms;

namespace Task2
{
    public class Worker
    {
        public bool Fihish { get; set; } = false;
        public ProgressBar ProgressBar { get; }
        public int NumberWorker { get; } //Номер лошади
        public int Place { get; set; } //Итоговое место на гонках

        public Worker(ProgressBar progressBar, int numberWorker)
        {
            this.ProgressBar = progressBar;
            this.NumberWorker = numberWorker;
        }

        public void Work(Random random)
        {
            int distance = 0;
            do
            {
                Thread.Sleep(50);
                int speed = random.Next(1, 5);
                distance += speed;
                if (distance > ProgressBar.Maximum)
                    distance = ProgressBar.Maximum;
                ProcessChanged(distance, ProgressBar);
            } while (ProgressBar.Maximum > distance);
            Fihish = true;
            WorkCompleted(NumberWorker);
        }

        public event Action<int, ProgressBar> ProcessChanged;
        public event Action<int> WorkCompleted;
    }
}
