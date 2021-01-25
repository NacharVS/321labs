using System;
using System.Threading;


namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCreationStart p1 = new GameCreationStart("Alo", 10, 3, 30);
            GameCreationStart p2 = new GameCreationStart("Alo1", 9, 4, 33);
            GameCreationStart p3 = new GameCreationStart("Alo2", 8, 5, 34);
            GameCreationStart p4 = new GameCreationStart("Alo3", 7, 3, 35);
            GameCreationStart p5 = new GameCreationStart("Alo4", 6, 2, 36);
            GameCreationStart p6 = new GameCreationStart("Alo5", 5, 2, 37);

            string stat = GameCreationStart.SearchByName("Alo1");
            Console.WriteLine(stat);

        }
    }
}
