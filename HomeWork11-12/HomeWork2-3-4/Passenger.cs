using System.Threading;

namespace HomeWork2_3_4
{
    public class Passenger
    {
        private string name;

        public Passenger(string name) => this.name = name;

        public override string ToString() => $"{name}";       
    }
}
