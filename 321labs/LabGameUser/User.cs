using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _321labs.LabGameUser
{
    class User
    {
        public static List<User> Users = new List<User>();
        string userName;
        DateTime dayOfBirth = new DateTime();
        int finishedMatches;
        int victories;
        float gamePoints;

        public User(string userName, DateTime dayOfBirth, int finishedMatches, int victories, float gamePoints)
        {
            this.userName = userName;
            this.dayOfBirth = dayOfBirth;
            this.finishedMatches = finishedMatches;
            this.victories = victories;
            this.gamePoints = gamePoints;
            Users.Add(this);
        }

        public string UserName { get => userName; set => userName = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        public int Victories { get => victories; set => victories = value; }
        public float GamePoints { get => gamePoints; set => gamePoints = value; }

        private static List<User> searchByName(string userName)
        {
            var a = Users.Where(u=> u.userName.Equals(userName)).ToList();
            return a; 
        }

        public static string SearchByName(string userName)
        {
            var a= searchByName(userName);
            return $"{a[0].UserName} {a[0].DayOfBirth.Date} {a[0].FinishedMatches} {a[0].Victories} {a[0].GamePoints}";
        }

        public static string GameStats()
        {
            return "Количество сыграных матчей в системе: "+Users.Sum(u => u.finishedMatches);
        }
    }
}
