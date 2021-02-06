using _321labs.Game;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //AsyncStart async = new AsyncStart();
            //async.Start();
            //Console.ReadKey();

            //WorkWIthBD.Update();
            //WorkWIthBD.Replace();
            WorkWIthBD.SaveDocs();
            Console.ReadKey();
        }
    }
}
