using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    delegate void MatchHandler(Player p1, Player p2);
    class ProgramSimulation
    {
        public static event MatchHandler match; 
        static void Start(Player p1, Player p2)
        {
            match(p1,p2);
            //пример работы программы
            

            Worker wk = new Worker(100, 100);
            p1.StartingCC.Produce(wk);
            Generator gn = new Generator(90, 90);
            wk.Produce(gn);
            gn.Generate();
            Factory fc = new Factory(95, 95);
            gn.Generate();
            wk.Produce(fc);
            Replicant rep = new Replicant(80, 80);
            fc.Produce(rep);
            gn.Generate();
            rep.Produce(new Nanite(rep.X, rep.Y));
            rep.Produce(new Nanite(rep.X, rep.Y));
            rep.Produce(new Nanite(rep.X, rep.Y));
            rep.Produce(new Nanite(rep.X, rep.Y));

            foreach (var item in rep.Nanites)
            {
                item.Attack(p2.StartingCC);
            }
        }
    }
}
