using _321labs.GameCreateStat;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    static class GameCreationStart
    {
        private static string userName;
        private static DateTime dayOfBirth;
        private static int finishedMatches;
        private static int victories;
        private static int gamePoints;

        public static string UserName { get => userName; set => userName = value; }
        public static DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public static int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        public static int Victories { get => victories; set => victories = value; }
        public static int GamePoints { get => gamePoints; set => gamePoints = value; }

        public static List<Player> players = new List<Player>() 
        { 
            new Player("Oleg", new DateTime(2002,5,5), 10, 5, 100),
            new Player("Tigran", new DateTime(2002,9,6), 20, 4, 200)
        };

        public static string SearchByName(string userName)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name == userName)
                {
                    return $"Name: {players[i].Name},\n Day of birth: {players[i].DayOfBirth},\n Finished matches: {players[i].FinishedMatches}," +
                        $"\n Victories: {players[i].Victories},\n Game point: {players[i].GamePoints}";
                }
            }
            return "";
        }
        public static void GameStat()
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine(players[i]);
            }
        }
    }
}
