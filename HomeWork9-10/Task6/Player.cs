using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Player
    {
        private string name;
        private decimal balance;
        public int bet { get; set; }

        public Player(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public void setBalance(decimal balance) => this.balance += balance;
        public override string ToString() => $"Имя игрока: {name}. Баланс: {balance}. Ставка: {bet}";
    }
}
