namespace HomeWork2_3_4
{
    public class Bus
    {
        public int number { get; } //номер автобуса
        public int maxNumberSeats { get; }//Вместимость
        public int FreePlaces { get; set; }//Свободныъ мест

        public Bus(int number, int maxNumberSeats)
        {
            this.number = number;
            this.maxNumberSeats = maxNumberSeats;          
        }

        public override string ToString() => $"Номер автобуса: {number}. Вместимость пассажиров: {maxNumberSeats}. Свободных мест: {FreePlaces}";
    }
}
