using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork2_3_4
{
    public class Bus
    {
        private string number; //номер автобуса
        public int maxNumberSeats { get; }//количество свободных мест

        public Bus(string number, int maxNumberSeats)
        {
            this.number = number;
            this.maxNumberSeats = maxNumberSeats;
            
        }


        public override string ToString()
        {
            return $"Номер автобуса: {number}.";
        }



    }
}
