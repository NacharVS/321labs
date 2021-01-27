using System;
using System.Threading;
using System.Collections.Generic;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {

            User u1 = new User("Zaza", new DateTime(22 / 11 / 2008), 30, 25, 400);
            User u2 = new User("Laz", new DateTime(22 / 11 / 2008), 30, 10, 200);
            User u3 = new User("Hja", new DateTime(22 / 11 / 2008), 40, 10, 600);
            User u4 = new User("AAza", new DateTime(22 / 11 / 2008), 60, 40, 980);
            User u5 = new User("Asza", new DateTime(22 / 11 / 2008), 40, 20, 800);

            var search = User.ByName("Laz");
            foreach (var item in search)
            {
                Console.WriteLine("Name - {0}, His victories - {1}, His game point - {2}", item.UserName, item.Vicroties, item.GamePoint);
            }

            Console.WriteLine("All matches - {0}",User.GameStats());

        }
    }
}
