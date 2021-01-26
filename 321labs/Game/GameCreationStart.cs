using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Game
{
    class GameCreationStart
    {
        static List<GameCreationStart> game = new List<GameCreationStart>();

        string userName;           //Имя пользователя.
        DateTime dayOfBirth;      //День рождения.
        int finishedMatches;     //Законченные матчи.
        int victories;          //Победы.
        int gamePoints;        //Игровые очки.

        public string UserName { get => userName; set => userName = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        public int Victories { get => victories; set => victories = value; }
        public int GamePoints { get => gamePoints; set => gamePoints = value; }

        public GameCreationStart (string userName, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            this.userName = userName;
            this.dayOfBirth = dayOfBirth;
            this.finishedMatches = finishedMatches;
            this.victories = victories;
            this.gamePoints = gamePoints;
        }

        public static List<GameCreationStart> SearchByName(string userName)
        {
            List<GameCreationStart> gameCreationStarts = new List<GameCreationStart>();
            Parallel.ForEach(game, g =>
            {
                if (g.UserName == userName)
                {
                    gameCreationStarts.Add(g);
                }
            });
            return gameCreationStarts;
        }

        public static int GameStat()
        {
            return game.Sum(f => f.FinishedMatches);
        }
    }
}
