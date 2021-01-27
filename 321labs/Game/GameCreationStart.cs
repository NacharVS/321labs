using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _321labs.Game
{
    class GameCreationStart
    {
        private string nameUser;
        private DateTime dayOfBirth = new DateTime();
        private int finishedMatches;
        private int victories;
        private int gamePoints;
         public static List<GameCreationStart> gameCreationStarts = new List<GameCreationStart>();

        public string NameUser
        {
            get
            {
                return nameUser;
            }
            set
            {
                this.nameUser = value;
            }
        }
        public DateTime DayOfBirth
        {
            get
            {
                return dayOfBirth;
            }
            set
            {
                this.dayOfBirth = value;
            }
        }
        public int FinishedMatches
        {
            get
            {
                return finishedMatches;
            }
            set
            {
                this.finishedMatches = value;
            }
        }
        public int Victories
        {
            get
            {
                return victories;
            }
            set
            {
                this.victories = value;
            }
        }
        public int GamePoimts
        {
            get
            {
                return gamePoints;
            }
            set
            {
                this.gamePoints = value;
            }
        }
        public GameCreationStart(string nameUser, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            this.nameUser = nameUser;
            this.dayOfBirth = dayOfBirth;
            this.finishedMatches = finishedMatches;
            this.victories = victories;
            this.gamePoints = gamePoints;
            gameCreationStarts.Add(this);

        }
        public static string SearchByName(string userName)
        {
            GameCreationStart a = null;
            foreach (var i in gameCreationStarts) { if (i.NameUser == userName) { a = i; break; } }
            if (a!= null)
            {
                return $"{a.NameUser} {a.DayOfBirth.Date} {a.FinishedMatches} {a.Victories} {a.DayOfBirth}";
            }
            else return $"Нет игрока с именем {userName}";
        }
        public static void GameStat()
        {
            return gameCreationStarts.Sum(u=>u.finishedMatches);
        }






    }
}
