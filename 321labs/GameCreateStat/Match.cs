using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.GameCreateStat
{
    class Match
    {
        public int PointsFirstTeam { get; set; }
        public int PointsLastTeam { get; set; }
        public bool isVictory { get; set; }


        public Match(int pointsFirstTeam, int pointsLastTeam, bool isVictory)
        {
            PointsFirstTeam = pointsFirstTeam;
            PointsLastTeam = pointsLastTeam;
            this.isVictory = isVictory;
        }
    }
}
