using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class ProgramSimulation
    {
        static void Start()
        {
            //пример работы программы
            Player p1 = new Player(100, 100);
            Player p2 = new Player(-100, -100);

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
