using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Task6
{
    public class Casino
    {
        const int maxPlayerTable = 5; //максимальное количество игроков за столом
        public int leftPlayers; //оставшееся количество посетилей
        public static Semaphore semaphore = new Semaphore(maxPlayerTable, maxPlayerTable, "Spartak(Moscow)");
        static Random userRandom = new Random();
        public List<Player> players { get; }

        public Casino(int leftPlayers)
        {
            players = new List<Player>();
            this.leftPlayers = leftPlayers;
            for (int i = 0; i < leftPlayers; i++)
                players.Add(new Player("Игрок " + i, userRandom.Next(1000, 2000), new Thread(Play)));
        }

        public void Play(object player)
        {
            semaphore.WaitOne();
            LogInfo($"Игрок {(player as Player).name} начал игру");
            while ((player as Player).Balance > 0 && (player as Player).NumberRoundsPlayed < 8)
            {
                Thread.Sleep(3000);
                (player as Player).NumberRoundsPlayed++;
                (player as Player).GameNumber = new Random().Next(1, 37);
                (player as Player).PlayerNumber = userRandom.Next(1, 37);
                (player as Player).Bet = userRandom.Next(100, 300);
                (player as Player).ChooiseBalance();
                LogInfo((player as Player).ToString());
            }
            InfoCountPlayer($"Число оставшихся потенциальных игроков за день: {--leftPlayers}");
            semaphore.Release();
            if ((player as Player).Balance == 0)
                LogInfo($"У игрока {(player as Player).name} закончились бабки");
            if (leftPlayers == 0)
                EndGame(players);
        }

        public event Action<string> LogInfo;
        public event Action<string> InfoCountPlayer;
        public event Action<List<Player>> EndGame;
    }
}
