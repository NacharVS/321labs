using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class GameCreationStart
    {
        string userName;
        int finishedMatches;
        int victories;
        int gamePoints;
        public string UserName { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }
        static List<GameCreationStart> usersList = new List<GameCreationStart>();

        public GameCreationStart(string userName, int finishedMatches, int victories, int gamePoints)
        {
            UserName = userName;
            FinishedMatches = finishedMatches;
            Victories = victories;
            GamePoints = gamePoints;
            usersList.Add(this);
        }

        public static List<GameCreationStart> SearchByName(string userName)
        {
            List<GameCreationStart> players = new List<GameCreationStart>();
            Parallel.ForEach(usersList, user =>
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
            return $"Finished matches: {this.FinishedMatches} | Victories: {this.Victories}";
        }
        
    }
}
