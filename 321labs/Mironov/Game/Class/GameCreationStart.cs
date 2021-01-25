using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Game.Class
{
    class GameCreationStart
    {
        private string userName;
        private DateTime dayOfBirth;
        private int finishedMatches;
        private int victories;
        private int gamePoints;

        public GameCreationStart(string userName, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            UserName = userName;
            DayOfBirth = dayOfBirth;
            FinishedMatches = finishedMatches;
            Victories = victories;
            GamePoints = gamePoints;
        }

        public string UserName { get => userName; set => userName = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        public int Victories { get => victories; set => victories = value; }
        public int GamePoints { get => gamePoints; set => gamePoints = value; }


    }
}
