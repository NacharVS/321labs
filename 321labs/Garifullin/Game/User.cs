using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Garifullin.Game
{
    class User
    {
        private string userName;
        private DateTime dayOfBirth;
        private int finishedMatches;
        private int victories;
        private int gamePoints;
        private static List<User> listOfUsers = new List<User>();
        public string UserName 
        { 
            get => userName; 
            set => userName = value; 
        }
        public DateTime DayOfBirth 
        { 
            get => dayOfBirth; 
            set => dayOfBirth = value; 
        }
        public int FinishedMatches 
        { 
            get => finishedMatches; 
            set => finishedMatches = value; 
        }
        public int Victories 
        { 
            get => victories; 
            set => victories = value; 
        }
        public int GamePoints 
        { 
            get => gamePoints; 
            set => gamePoints = value; 
        }

        public User(string userName, DateTime dayOfBirth)
        {
            this.UserName = userName;
            this.DayOfBirth = dayOfBirth;
            listOfUsers.Add(this);
        }
        public static void SearchByName(string name)
        {
            List<User> users = new List<User>();
            Parallel.ForEach(listOfUsers, u =>
            {
                if (name == u.userName)
                {
                    users.Add(u);
                    
                }
            });
            foreach (var item in users)
            {
                Console.WriteLine($"{item.DayOfBirth}, {item.FinishedMatches}, {item.Victories}, {item.GamePoints}");
            }
        }

        public int GameStat()
        {
            return this.FinishedMatches;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ы", new DateTime(1930, 3, 13));
            User user1 = new User("Ы", new DateTime(1940, 5, 18));
            User user12 = new User("Ы", new DateTime(1940, 5, 18));

            Console.WriteLine(user.GameStat());
            User.SearchByName("Ы");
            Console.WriteLine("Leave hope behind all who enters here....");
        }
    }
}
