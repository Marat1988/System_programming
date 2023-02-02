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
            if ((thread == null) || (thread.ThreadState == ThreadState.Aborted)
                || (thread.ThreadState == ThreadState.Stopped))
            {
                ThreadStart threadStart = new ThreadStart(del);
                //Простые числа
                thread = new Thread(threadStart);
                thread?.Start();
            }
        }
        //Остановка потока
        public void Abort()
        {
            if (thread?.IsAlive == true && thread?.ThreadState != ThreadState.Suspended)
                thread?.Abort();
        }
        //Приостановка потока
        [Obsolete]
        public void Suppent()
        {
            if (thread?.IsAlive == true)
                thread?.Suspend();
        }
        //Возобновление работы потока
        [Obsolete]
        public void Resume()
        {
            if (thread?.ThreadState == ThreadState.Suspended)
                thread?.Resume();
        }
        //Рестарт потока
        public void Restart()
        {
            if (thread?.ThreadState != ThreadState.Suspended)
            {
                Abort();
                Run();
            }
        }

        public bool checkState() => (thread != null) && (thread?.IsAlive == true);       
    }
}
