using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class User
    {
        string userName;
        DateTime dayOfBirth;
        int finishedMatch;
        int vicroties;
        double gamePoint;
        List<User> users = new List<User> { };

        public string UserName { get => userName; set => userName = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatch { get => finishedMatch; set => finishedMatch = value; }
        public int Vicroties { get => vicroties; set => vicroties = value; }
        public double GamePoint { get => gamePoint; set => gamePoint = value; }

        public User(string userName, DateTime dayOfBirth, int finishedMatch, int victories, double gamePoint)
        {
            UserName = userName;
            DayOfBirth = dayOfBirth;
            FinishedMatch = finishedMatch;
            Vicroties = victories;
            GamePoint = gamePoint;
            users.Add(this);
        }
        
        public void ByName(string nameUser)
        {
            Parallel.ForEach(users, item =>
            {
                if (item.UserName == nameUser)
                {
                    Console.WriteLine();
                }
            });
            
        }
    }
}
