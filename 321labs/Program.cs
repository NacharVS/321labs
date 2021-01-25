using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GameCreationStart.SearchByName("Oleg"));
            GameCreationStart.GameStat();
        }
    }
}
