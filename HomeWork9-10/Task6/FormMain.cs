using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Task6
{
    public partial class FormMain : Form
    {
        private const int maxPlayer = 6;
        private Semaphore semaphore = new Semaphore(maxPlayer, maxPlayer, "Казино_рояль");
        private Thread[] threads = new Thread[maxPlayer];
        private List<Player> players = new List<Player>();
        Random random = new Random();

        public FormMain()
        {
            InitializeComponent();
            buttonStartGame.Click += ButtonStartGame_Click;
         }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            MyThread.semaphore = new Semaphore(3, 3, "Марат");



            MyThread[] myThreads = new MyThread[7];
            for (int i = 0; i < myThreads.Length; i++)
            {
                myThreads[i] = new MyThread("Марат " + i, 30);
                myThreads[i].LogInfo += Worker_LogInfo;
            }


            Thread[] threads = new Thread[7];


            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(myThreads[i].Run);
                myThreads[i].random1 = random;
                threads[i].Start(new Random(100));   
            }
        }

        private void Worker_LogInfo(string info)
        {
            Action action = () => { listBoxPlayerLog.Items.Add(info); };
            this.InvokeEx(action);
        }
    }
}
