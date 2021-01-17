using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Player
    {
        
        CommandCenter startingCC;
        int energy = 1000;
        public int Energy { get => energy; set => energy = value; }
        internal CommandCenter StartingCC { get => startingCC; set => startingCC = value; }

        public Player(double x, double y)
        {
            StartingCC = new CommandCenter(x, y);
            StartingCC.Team = this;
        }
    }
}
