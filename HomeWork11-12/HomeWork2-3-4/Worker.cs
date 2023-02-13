using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HomeWork2_3_4
{
    public class Worker
    {
        private DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
        private List<Bus> buses;
        private ManualResetEvent ManualResetEvent = new ManualResetEvent(false);
        private List<Passenger> passengers;
        private static Random rand = new Random();
        private string[] namePassengers = { "Алкоголик", "Наркоман", "Тунеядец", "Футболист", "Проститутка", "Сутенер", "Студент академии ТОП", "Преподаватель-недоучка" };

        public Worker(List<Bus> buses)
        {
            this.buses = buses;
            passengers = new List<Passenger>();
        }

        private void GetOnTheBus(object bus) //Пассажир садится в автобус
        {
            ManualResetEvent.WaitOne();
            for (int i = 0; i < (bus as Bus).FreePlaces; i++)
            {
                if (passengers.Count > 0)
                {
                    Passenger passenger = passengers.Where(p => p.expectedBusNumber == (bus as Bus).number).FirstOrDefault();
                    if (passenger != null)
                    {
                        infoPassenger("Пассажир " + passenger.ToString() + " сел в автобус");
                        passengers.Remove(passenger);
                        infoPassengerCount($"Количество пассажиров на остановке: {passengers.Count}");
                    }
                }
            }
        }

        public void BusIsOnItsWay() //автобус в пути
        {
            while (dateTime.Hour < 22)
            {
                Thread.Sleep(1000);
                dateTime = dateTime.AddMinutes(1);
                getTime("Текущее время: " + dateTime.ToShortTimeString());
                if (dateTime.Minute % 15 == 0)
                {
                    Bus bus = buses[rand.Next(buses.Count)]; //Генерируем случайно выбранный автобус
                    bus.FreePlaces = rand.Next(1, bus.maxNumberSeats + 1); //Определяем случайное количество свободных мест
                    Thread thread = new Thread(GetOnTheBus);
                    thread.Start(bus);
                    infoBus("Подъехал автобус. " + bus.ToString());
                    ManualResetEvent.Set();
                    ManualResetEvent.Reset();
                }
            }
        }

        public void PaggengerGo() //Пассажиры приходят на остановку
        {
            int countPassanger = 0;
            while (dateTime.Hour < 22)
            {
                if (dateTime.Minute % 3 == 0)
                {
                    int randomCountpassengers = rand.Next(1, 6); //Приток пассажиров на остановку. Случайное количество.
                    Thread.Sleep(1000);
                    for (int i = 0; i < randomCountpassengers; i++)
                    {
                        string namePassenger = namePassengers[rand.Next(namePassengers.Length)] + countPassanger.ToString();
                        Passenger passenger = new Passenger(name: namePassenger, expectedBusNumber: buses[rand.Next(buses.Count)].number);
                        passengers.Add(passenger);
                        infoPassenger(passenger.ToString() + " приперся на остановку");
                        infoPassengerCount($"Количество пассажиров на остановке: {passengers.Count}");
                        countPassanger++;
                    }
                }
            }
        }

        public event Action<string> infoBus;
        public event Action<string> getTime;
        public event Action<string> infoPassenger;
        public event Action<string> infoPassengerCount;
    }
}
