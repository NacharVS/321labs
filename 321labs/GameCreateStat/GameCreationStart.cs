using _321labs.GameCreateStat;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    static class GameCreationStart
    {
        private static List<Player> players = new List<Player>()
        {
            new Player("Oleg", new DateTime(2002,5,5), 10, 5, 100),
            new Player("Tigran", new DateTime(2002,9,6), 20, 4, 200)
        };

        private static List<Match> matches = new List<Match>()
        {
            new Match(100,200,false),
            new Match(200,87, true)
        };

        public static string SearchByName(string userName)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name == userName)
                {
                    return $"Name: {players[i].Name}\nDay of birth: {players[i].DayOfBirth}\nFinished matches: {players[i].FinishedMatches}" +
                        $"\nVictories: {players[i].Victories}\nGame point: {players[i].GamePoints}";
                }
            }
            return "";
        }
        public static void GameStat()
        {
            for (int i = 0; i < matches.Count; i++)
            {
                Console.WriteLine($"\nPoints first team: {matches[i].PointsFirstTeam}\nPoints last team: {matches[i].PointsLastTeam}\nVictory:{matches[i].isVictory}");
            }
        }
    }
}
