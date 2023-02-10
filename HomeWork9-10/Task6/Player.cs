using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task6
{
    public class Player
    {
        public Thread thread { get; }
        public string name { get; } 
        public int Balance { get; set; } //текущий баланс у игрока
        private int bet; //Ставка игрока
        public int GameNumber { get; set; } //Выпавшее число в рулетке
        public int PlayerNumber { get; set; } //Число игрока
        public int StartMoney { get; } //Стартовый баланс игрока
        public int NumberRoundsPlayed { get; set; } = 0; //число сыгранных раундов

        public Player(string name, int balance, Thread thread)
        {
            this.name = name;
            Balance = balance;
            this.thread = thread;
            this.StartMoney = balance;
        }

        public int Bet
        {
            get
            {
                return bet;
            }
            set
            {
                bet = (value > Balance) ? Balance : value;
            }
        }

        public void ChooiseBalance()
        {
            if (GameNumber == PlayerNumber)
                Balance += (Bet * 2);
            else
                Balance -= Bet;
        }

        public override string ToString() => $"{name}. Ставка игрока: {Bet}. Число игрока: {PlayerNumber}. Выпавшее число в рулетке {GameNumber}. Текущий баланс: {Balance} ";
    }
}
