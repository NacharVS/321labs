using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Fedotov
{
    class GameCreationStart
    {
        private static List<GameCreationStart> Players = new List<GameCreationStart>();
        public string UserName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public GameCreationStart()
        {
            
        }

        public GameCreationStart(string userName, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            UserName = userName;
            DayOfBirth = dayOfBirth;
            FinishedMatches = finishedMatches;
            Victories = victories;
            GamePoints = gamePoints;
            Players.Add(this);
        }

        public static GameCreationStart SearchByName(string name)
        {
            GameCreationStart player = new GameCreationStart();
            Parallel.ForEach(Players, (p) =>
            {
                if (p.UserName == name)
                    player = p;
            });
            return player;
        }

        public static int GameStat()
        {
            return Players.Sum(f => f.FinishedMatches);
        }
    }
}
