using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork2_3_4
{
    public class Passenger
    {
        private string name;
        public Thread thread { get; }

        public Passenger(string name,Thread thread)
        {
            this.name = name;
            this.thread = thread;
        }

        public int getCurrencThreadId() => thread.ManagedThreadId;

        public override string ToString() => $"Имя: {name}. Id потока: {thread.ManagedThreadId}";       
    }
}
