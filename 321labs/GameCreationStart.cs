using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class GameCreationStart
    {
        //public string UserName { get; set; }
        // public DateTime DayOfBitrh = new DateTime();
        // public int FinishedMatch { get; set; }
        // public int Victories { get; set; }
        // public int GamePoints { get; set; }
        // private string username;
        // private DateTime dayofbirth;
        // private int finishedmatch;
        // private int victories;
        // private int gamepoints;
        private string username;
        private int finishedmatches;
        private int victories;
        private int gamepoints;
        private DateTime dayofbirth;

        public string UserName
        {
            get
            {
                return username;
            }
            private set
            {
                username = value;
            }
        }
        public DateTime DayOfBirth
        {
            get
            {
                return dayofbirth;
            }
            private set
            {
                dayofbirth = value;
            }
        }
        public int FinishedMatches
        {
            get
            {
                return finishedmatches;
            }
            private set
            {
                finishedmatches = value;
            }
        }
        public int Victories
        {
            get
            {
                return victories;
            }
            private set
            {
                victories = value;
            }
        }
        public int gamePoints
        {
            get
            {
                return gamepoints;
            }
            private set
            {
                gamepoints = value;
            }
        }
        public GameCreationStart(string username, DateTime dayofbirth, int finishedmatches, int victories, int gamepoints)
        {
            this.UserName = username;
            this.DayOfBirth = dayofbirth;
            this.FinishedMatches = finishedmatches;
            this.Victories = victories;
            this.gamePoints = gamepoints;
        }

        public void SearchByName(GameCreationStart game)
        {
            Console.WriteLine($"Информация о пользователе:\n{username}\n" +
                $"Дата Рождения {dayofbirth}");
        }
        public void GameStat(GameCreationStart game)
        {
            Console.WriteLine($"Количество сыгранных матчей - {finishedmatches}\n" +
                $"Количество побед - {victories}\n" +
                $"Количесвто заработанных очков - {gamepoints}");
        }
        static void Main(string[] args)
        {
            GameCreationStart player1 = new GameCreationStart("Раниль", new DateTime(2002, 12, 7), 10, 52, 13);
            GameCreationStart player2 = new GameCreationStart("Иван", new DateTime(2013, 3, 5), 60, 22, 23);
            GameCreationStart player3 = new GameCreationStart("Сергей", new DateTime(2020, 11, 23), 30, 72, 63);
            GameCreationStart player4 = new GameCreationStart("Владимир", new DateTime(2021, 1, 5), 50, 82, 43);
            player1.GameStat(player1);
            player2.GameStat(player2);
            player3.GameStat(player3);
            player4.GameStat(player4);
            player1.SearchByName(player1);
            player2.SearchByName(player2);
            player3.SearchByName(player3);
            player4.SearchByName(player4);

        }
    }
}
