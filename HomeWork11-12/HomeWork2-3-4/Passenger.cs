using System.Threading;

namespace HomeWork2_3_4
{
    public class Passenger
    {
        private string name;
        public int expectedBusNumber;

        public Passenger(string name, int expectedBusNumber)
        {
            this.name = name;
            this.expectedBusNumber = expectedBusNumber;
        }

        public override string ToString() => $"{name}. Ожидаемый номер автобуса: {expectedBusNumber}";       
    }
}
