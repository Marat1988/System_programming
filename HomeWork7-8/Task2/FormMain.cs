using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Task2
{
    public partial class FormMain : Form
    {
        private List<Worker> workers = new List<Worker>();
        Random random = new Random();
        private int place = 1;
        public FormMain()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            workers.Clear();
            int numberHourse = 1;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is ProgressBar)
                {
                    workers.Add(new Worker(Controls[i] as ProgressBar, numberHourse));
                    workers[workers.Count - 1].ProcessChanged += Worker_ProcessChanged;
                    workers[workers.Count - 1].WorkCompleted += Worker_WorkCompleted;
                    numberHourse++;
                }
            }
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < workers.Count(); i++)
            {
                ParameterizedThreadStart ts = new ParameterizedThreadStart(StartMethodWorker);
                threads.Add(new Thread(ts));
            }
            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].Start((object)i);
            }
            buttonStart.Enabled = false;
        }

        private void StartMethodWorker(object index)
        {
            workers[int.Parse(index.ToString())].Fihish = false;
            workers[int.Parse(index.ToString())].Work(random);
        }

       private void Worker_WorkCompleted(int numberWorker)
       {
            Worker horse = workers.Where(workers => workers.NumberWorker == numberWorker).FirstOrDefault();
            horse.Place = place;
            place++;

            int leftHorseFinish = workers.Where(worker => worker.Fihish == false).Count(); //Считаю, сколько лошадей не финишировало
            if (leftHorseFinish == 0) //Все финишировали
            {
                Action action = () =>
                {
                    var sql = (from worker in workers
                               select new
                               {
                                   Имя_лошади = worker.ProgressBar.Name,
                                   Номер_лошади = worker.NumberWorker,
                                   Итоговое_место = worker.Place,
                               }).ToList();
                    MessageBox.Show("Все финишировали", "Лошадинные гонки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewStatistic.DataSource = null;
                    dataGridViewStatistic.DataSource = sql;
                    buttonStart.Enabled = true;
                    place = 1;
                };
                this.InvokeEx(action);
            }
        }

        private void Worker_ProcessChanged(int progress, ProgressBar progressBar)
        {
            Action action = () => progressBar.Value = progress;
            this.InvokeEx(action);
        }
    }
}
