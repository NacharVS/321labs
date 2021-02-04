using System;
using System.Threading;
using System.Collections.Generic;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker(200, "Peadro", 20, 19, 23, 50);
            Mongo.Add(worker).GetAwaiter().GetResult();

            Mongo.Replace(worker).GetAwaiter().GetResult();
            Console.ReadKey();
        }
    }
}
