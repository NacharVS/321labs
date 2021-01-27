using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.User
{
    class GameCreationStart
    {
        private string userName;
        private int matches;
        private int victories;
        private int gamePoints;
        public string UserName { get => userName; set => userName = value; }
        public int Matches { get => matches; set => matches = value; }
        public int Victories { get => victories; set => victories = value; }
        public int GamePoints { get => gamePoints; set => gamePoints = value; }

        static List<GameCreationStart> Users = new List<GameCreationStart>();

        public GameCreationStart(string userName, int matches, int victories, int gamePoints)
        {
            UserName = userName;
            Matches = matches;
            Victories = victories;
            GamePoints = gamePoints;
            Users.Add(this);
        }

        public static List<GameCreationStart> SearchByName(string userName)
        {
            List<GameCreationStart> players = new List<GameCreationStart>();
            Parallel.ForEach(Users, user =>
            {
                if (user.userName == userName)
                {
                    players.Add(user);
                }
            });
            return players;

        }
        public string GameStat()
        {
            return $"Player: {this.userName}" +
                $"Game points: {this.GamePoints}" +
            $"Finished matches: {this.Matches}" +
            $"Victories: {this.Victories}";
        }
    }
}
