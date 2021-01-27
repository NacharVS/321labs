using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class User
    {
        private string userName;
        private DateTime dayOfBirth;
        private int finishedMatch;
        private int vicroties;
        private double gamePoint;
        private static List<User> users = new List<User> { };

        public string UserName { get => userName; set => userName = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatch { get => finishedMatch; set => finishedMatch = value; }
        public int Vicroties { get => vicroties; set => vicroties = value; }
        public double GamePoint { get => gamePoint; set => gamePoint = value; }

        public User(string userName, DateTime dateTime, int finishMatches, int vicroties, int gamePoint)
        {
            UserName = userName;
            DayOfBirth = dateTime;
            FinishedMatch = finishMatches;
            Vicroties = vicroties;
            GamePoint = gamePoint;
            users.Add(this);
        }
        
        public static List<User> ByName(string name)
        {
            List<User> man = new List<User>();
            Parallel.ForEach(users, p =>
            {
                if (p.userName == name)
                {
                    man.Add(p);
                }
            });
            return man;
        }
        public static int GameStats()
        {
            int sum = 0;
            foreach (var user in users)
            {
                sum += user.FinishedMatch;
            }

            return sum;
        }
    }
}
