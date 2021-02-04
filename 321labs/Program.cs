using System;

using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("sas",200,100,300,5,50,300,50);
            Hero hero1 = new Hero("sosisochka", 300, 300, 300, 300, 300, 300, 300);


            mongocrud.Replace(hero1).GetAwaiter().GetResult();
            Console.ReadLine();
        
        }
    }
}
