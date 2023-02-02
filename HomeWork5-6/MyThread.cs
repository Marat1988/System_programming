using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork5_6
{
    public class MyThread
    {
        private Thread thread;
        private Action del;

        public Thread Thread { get => thread; set => thread = value; }

        public MyThread(Action del)
        {
            this.del += del;
        }


        public Thread ThreadInfo
        {
            get => thread;
        }

        //Запуск
        public void Run()
        {
            if ((Thread == null) || (Thread.ThreadState == ThreadState.Aborted)
                || (Thread.ThreadState == ThreadState.Stopped))
            {
                ThreadStart threadStart = new ThreadStart(del);
                //Простые числа
                Thread = new Thread(threadStart);
                Thread?.Start();
            }
        }

        //Остановка потока
        public void Abort()
        {
            if (Thread?.IsAlive == true)
                Thread?.Abort();
        }
        //Приостановка потока
        [Obsolete]
        public void Suppent()
        {
            if (Thread?.IsAlive == true)
                Thread?.Suspend();
        }
        //Возобновление работы потока
        [Obsolete]
        public void Resume()
        {
            if (Thread?.ThreadState == ThreadState.Suspended)
                Thread?.Resume();
        }
        //Рестарт потока
        public void Restart()
        {
            if (Thread?.ThreadState != ThreadState.Suspended)
            {
                Abort();
                Run();
            }
        }


    }
}
