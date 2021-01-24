using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class OgrFixxer : Unit, IWorker
    {
        public int WorkPower { get; set; }
        public OgrFixxer(int phealth, int pexperience, int pposition, string pname, int pworkPower) : base(phealth, pexperience, pposition, pname)
        {
            this.WorkPower = pworkPower;
            Console.WriteLine("Огр создан");
        }
        public void Improve(Building building)
        {
            int temp = building.Health;
            if (building is Farm)
            {
                building.Health += WorkPower * 2;
            }
            else
            {
                building.Health += WorkPower;
            }
            Console.WriteLine($"Здоровье {building.Name} улучшено с {temp} на {building.Health}");
        }
    }
}
