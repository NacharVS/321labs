using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs
{
    class GameCreationStart
    {
        private string userName;
        private DateTime dayOfBirth;
        private int finishedMatches;
        private int victories;
        private int gamePoints;
        static List<GameCreationStart> gameCreationStarts = new List<GameCreationStart>();

        public DateTime DayOfBirth { get; set; }
        public string UserName { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }


        public GameCreationStart(string userName, int finishedMatches, int gamePoints)
        {
            UserName = this.userName;
            //DayOfBirth = this.dayOfBirth;
            FinishedMatches = this.finishedMatches;
            GamePoints = this.gamePoints;
            gameCreationStarts.Add(this);
        }
        public static List<GameCreationStart> SearchByName(string name)
        {
            List<GameCreationStart> dudes = new List<GameCreationStart>();
            Parallel.ForEach(gameCreationStarts, p =>
            {
                if (p.userName == UserName)
                {
                    dudes.Add(p);
                }
                return dudes;
            });
            
            );
            return s;
        }
    }
    }
