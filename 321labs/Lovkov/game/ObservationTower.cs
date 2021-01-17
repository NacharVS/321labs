using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov.game
{
    class ObservationTower : StayUnit
    {
        public ObservationTower(string name, int level, int hp, int armor, int range, int sight) : base(name, level, hp, armor, range, sight)
        {

        }

        public void Observ()
        {
            Console.WriteLine("Башня совершила осмотр. Врагов не найдено");
        }
    }
}
