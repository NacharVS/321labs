using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Mironov.Game.Class
{
    class User
    {
        private string userName;
        private DateTime dayOfBirth;
        private int finishedMatches;
        private int victories;
        private int gamePoints;
        private static List<User> userList= new List<User>();

    
        public string UserName { get => userName; set => userName = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        public int Victories { get => victories; set => victories = value; }
        public int GamePoints { get => gamePoints; set => gamePoints = value; }

        public User(string userName)
        {
            UserName = userName;
            DayOfBirth = DateTime.Now;
            FinishedMatches = 0;
            Victories = 0;
            GamePoints = 0;
            userList.Add(this);
        }

        public static List<User> SearchByName(string name)
        {
            List<User> result = new List<User>();
            Parallel.ForEach(userList, p =>
            {
                if (p.userName == name)
                {
                    result.Add(p);
                }
            });
            return result;
        }

        public static int GameStat()
        {
            int sum = 0;
            foreach (var user in userList)
            {
                sum += user.FinishedMatches;
            }

            return sum;
        }



    }
}
