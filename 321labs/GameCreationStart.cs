using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class GameCreationStart
    {
        string userName;
        DateTime dayOfBirth;
        int finishedMatches;
        int victories;
        int gamePoints;
        public string UserName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }
        static List<GameCreationStart> usersList = new List<GameCreationStart>();

        public GameCreationStart(string userName, int finishedMatches, int victories, int gamePoints)
        {
            UserName = userName;
            //DayOfBirth = dayOfBirth;
            FinishedMatches = finishedMatches;
            Victories = victories;
            GamePoints = gamePoints;
            usersList.Add(this);
        }

        public static string SearchByName(string userName)
        {
            string stats = null;
            Parallel.ForEach(usersList, user =>
            {
                if (user.userName == userName)
                {
                    stats = $"User: {userName} -- FinishedMatches:{user.FinishedMatches} -- Victories:{user.Victories} " +
                     $"-- GamePoints:{user.GamePoints}";
                }
            });
            returnn
        }
        
    }
}
