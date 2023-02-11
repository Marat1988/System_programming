using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork2_3_4
{
    public class Worker
    {
        private DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
        private Bus bus;
        private ManualResetEvent ManualResetEvent = new ManualResetEvent(false);
        private List<Passenger> passengers;
  

        public Worker(Bus bus)
        {
            this.bus = bus;
            passengers = new List<Passenger>();
        }

        public void getOnTheBus()
        {
            ManualResetEvent.WaitOne();
            Random random = new Random();
            int freePlaces = random.Next(1, bus.maxNumberSeats + 1);
            Semaphore semaphore = new Semaphore(freePlaces, freePlaces, "CheckPlaces");
            Passenger passenger = passengers.Where(p => p.getCurrencThreadId() == Thread.CurrentThread.ManagedThreadId).Single();
            infoPassenger(passenger.ToString() + " уехал на втобусе");
            passengers.Remove(passenger);
        }

        //автобус в пути
        public void BusIsOnItsWay()
        {
            while (dateTime.Hour < 22)
            {
                Thread.Sleep(1000);
                dateTime = dateTime.AddMinutes(1);
                getTime("Текущее время: " + dateTime.ToShortTimeString());
                if (dateTime.Minute % 15 == 0)
                {
                    infoBus("Подъехал автобус.");
                    ManualResetEvent.Set();
                    ManualResetEvent.Reset();
                }
            }
        }

        public void PaggengerGo()
        {
            int countPassanger = 0;
            while (dateTime.Hour < 22)
            {
                if (dateTime.Minute % 4 == 0)
                {
                    Thread thread = new Thread(getOnTheBus);
                    Passenger passenger = new Passenger(name: "Пассажир " + countPassanger, thread);
                    passengers.Add(passenger);
                    infoPassenger(passenger.ToString() + " приперся на остановку");
                    Thread.Sleep(1000);
                    passenger.thread.Start();
                    countPassanger++;
                }
            }
        }

        public event Action<string> infoBus;
        public event Action<string> getTime;
        public event Action<string> infoPassenger;
    }
}
