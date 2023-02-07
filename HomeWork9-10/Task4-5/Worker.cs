using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4_5
{
    public class Worker
    {
        private string[] fileNames = { "Thread1.txt", "Thread2.txt", "Thread3.txt" };
        private Mutex mutex;
        public Worker()
        {
            mutex = new Mutex();
        }

        public void Thread1()
        {
            mutex.WaitOne();
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            Random random = new Random();        
            using (StreamWriter writer = new StreamWriter(fileNames[0], false))
            {
                for (int i = 0; i < 100000; i++)
                {
                    int number = random.Next(1000);
                    writer.WriteLine(number.ToString());
                }
            }
            WorkEnd(Thread.CurrentThread.Name + " завершил свою работу");
            mutex.ReleaseMutex();
        }

        public event Action<string> WorkBegin;
        public event Action<string> WorkEnd;


    }
}
