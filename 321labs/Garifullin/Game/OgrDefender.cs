using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class OgrDefender : Unit, IWorker
    {
        public int WorkPower { get; set; }
        public OgrDefender(int phealth, int pexperience, int pposition, string pname, int pworkPower) : base(phealth, pexperience, pposition, pname)
        {
            this.WorkPower = pworkPower;
            Console.WriteLine("Огр создан");
        }
        public void Improve(Building building)
        {
            int temp = building.Defence;
            if (building is Turret)
            {
                building.Defence += WorkPower * 2;
            }
            else
            {
                building.Defence += WorkPower;
            }
            Console.WriteLine($"Защита {building.Name} улучшена с {temp} на {building.Defence}");
        }
    }
}
