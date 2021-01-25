using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Game
{
    class Player
    {
        string userName;
        DateTime birthDate;
        int finishedMathes;
        int victories;
        int gamePoints;
        
        CommandCenter startingCC;
        int energy = 1000;
        static List<Player> players = new List<Player>();
        
        public int Energy { get => energy; set => energy = value; }
        internal CommandCenter StartingCC { get => startingCC; set => startingCC = value; }

        public string UserName { get => userName; set => userName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public int FinishedMathes { get => finishedMathes; set => finishedMathes = value; }
        public int Victories { get => victories; set => victories = value; }
        public int GamePoints { get => gamePoints; set => gamePoints = value; }

        public Player(double x, double y)
        {
            StartingCC = new CommandCenter(x, y);
            StartingCC.Team = this;
            players.Add(this);
        }

        static Player()
        {
            ProgramSimulation.match += Player.MatchCounter;
        }

        public static List<Player> SearchByName(string name)
        {
            List<Player> dudes = new List<Player>();
            Parallel.ForEach(players, p =>
            {
                if (p.userName == name)
                {
                    dudes.Add(p);
                }
            });
            return dudes;
        }

        public static void MatchCounter(Player p1, Player p2)
        {
            p1.finishedMathes++;
            p2.finishedMathes++;
        }

        public int GameStat()
        {
            return this.finishedMathes;
        }

    }
}
