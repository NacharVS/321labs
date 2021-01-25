using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Koshelev;
using _321labs.Game;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCreationStart user1 = new GameCreationStart("Pasha", new DateTime(2019, 02, 20), 153, 76, 350);
            GameCreationStart user2 = new GameCreationStart("Valera", new DateTime(2018, 10, 10), 314, 203, 783);
            GameCreationStart user3 = new GameCreationStart("Kane", new DateTime(2008, 11, 04), 2302, 1843, 4871);
            GameCreationStart user4 = new GameCreationStart("Lil work", new DateTime(2014, 03, 20), 801, 375, 1332);
            GameCreationStart user5 = new GameCreationStart("Pimp", new DateTime(2011, 04, 30), 1145, 743, 2105);
            GameCreationStart user6 = new GameCreationStart("Vasa", new DateTime(2009, 01, 11), 1407, 698, 1593);

            var userSearch = GameCreationStart.SearchByName("Kane");
            Console.WriteLine(userSearch.UserName + " " + userSearch.FinishedMatches);
            Console.WriteLine(GameCreationStart.GameStat());
        }
    }
}
