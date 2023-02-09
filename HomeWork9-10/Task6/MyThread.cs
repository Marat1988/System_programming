using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task6
{
    public class MyThread
    {
        public static Semaphore semaphore = new Semaphore(3, 3, "Spartak(Moscow)");
        public string Name { get; set; }
        public int Money { get; set; }

        public Random random1;

        Random randomNumber = new Random();

        static Random userRandom = new Random();

        public MyThread(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public void Run(object randomShar)
        {
            semaphore.WaitOne();

            while (Money > 0)
            {
                int betPlayer = userRandom.Next(1, Money); //денежная ставка игрока
                //int NumberFellOut = randomNumber.Next(0, 37); //Выпавшее число на рулетке
                int NumberFellOut = (randomShar as Random).Next(0, 37); //Выпавшее число на рулетке
                int numberPlayer = userRandom.Next(0, 37); ; //Выпавшее число у игрока
                if (NumberFellOut == numberPlayer)
                    Money += (betPlayer * 2);
                else
                    Money -= betPlayer;
                LogInfo($"Имя: {Name}. Ставка игрока {betPlayer}р. Выпашее число у игрока: {numberPlayer}. Выпавшее число на рулетке: {NumberFellOut}. Осталось денег: {Money}р.");
                Thread.Sleep(3000);
            }
            semaphore.Release();
        }

        public event Action<string> LogInfo;
    }
}
