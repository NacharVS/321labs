using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class RanilAllWorker : Unit, IWorker
    {
        public int WorkPower { get; set; }
        public RanilAllWorker(int phealth, int pexperience, int pposition, string pname, int pworkPower) : base(phealth, pexperience, pposition, pname)
        {
            this.WorkPower = pworkPower;
            Console.WriteLine("Гений создан");
        }
        public void Improve(Building building)
        {
            int temp = building.Health;
            int alpha = building.Defence;
            if (building is Base)
            {
                building.Health += WorkPower * 2;
                building.Defence += WorkPower * 2;
            }
            else
            {
                building.Health += WorkPower;
                building.Defence += WorkPower;
            }
            Console.WriteLine($"Здоровье и защита {building.Name} улучшены с {temp} и {alpha} на {building.Health} и {building.Defence}");
        }
    }
}
