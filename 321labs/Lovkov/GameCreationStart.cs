using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov
{
    class GameCreationStart
    {
        private string username;
        private int finishedmatches;
        private int victories;
        private int gamepoints;
        private DateTime date1;

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
        public DateTime Date1
        {
            get
            {
                return date1;
            }
            private set
            {
                date1 = value;
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
        public GameCreationStart(string username, int finishedmatches, int victories, int gamepoints, DateTime date1)
        {
            this.FinishedMatches = finishedmatches;
            this.UserName = username;
            this.Victories = victories;
            this.gamePoints = gamepoints;
            this.Date1 = date1;
        }
        public void SearchByName(GameCreationStart name)
        {
            Console.WriteLine($"Ваши данные: Имя пользователя - {username} и Дата рождения - {date1}");
        }
        public void GameStat(GameCreationStart game)
        {
            Console.Write($"Данные о ваших играх:\nВсего сыгранных матчей - {finishedmatches}\nКоличество побед - {victories}\nКоличество набранных очков - {gamepoints}\n");
            Console.WriteLine();
        }
        //static void Main(string[] args)
        //{
        //    GameCreationStart z = new GameCreationStart("Андрей", 10, 10, 50, new DateTime(2002, 7, 20));
        //    z.GameStat(z);
        //    z.SearchByName(z);
        //}
    }
}
