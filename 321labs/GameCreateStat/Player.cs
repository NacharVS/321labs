using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.GameCreateStat
{
    class Player
    {
        private string name;
        private DateTime dayOfBirth;
        private int finishedMatches;
        private int victories;
        private int gamePoints;

        public string Name { get => name; set => name = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        public int Victories { get => victories; set => victories = value; }
        public int GamePoints { get => gamePoints; set => gamePoints = value; }

        public Player(string name, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            this.name = name;
            this.dayOfBirth = dayOfBirth;
            this.finishedMatches = finishedMatches;
            this.victories = victories;
            this.gamePoints = gamePoints;
        }

    }
}
