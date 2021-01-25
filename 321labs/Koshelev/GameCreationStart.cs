using System;
using System.Collections.Generic;
using System.Linq;
namespace _321labs.Koshelev
{
    class GameCreationStart
    {
        static List<GameCreationStart> game = new List<GameCreationStart>();

        public GameCreationStart(string userName, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            UserName = userName;
            DayOfBirth = dayOfBirth;
            Victories = victories;
            GamePoints = gamePoints;
            FinishedMatches = finishedMatches;

            game.Add(this);
        }

        public string UserName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public static GameCreationStart SearchByName(string userName)
        {
            return game.Find(u => u.UserName == userName);
        }

        public static int GameStat()
        {
            return game.Sum(p => p.FinishedMatches);
        }


    }
}
