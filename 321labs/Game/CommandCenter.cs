using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class CommandCenter : IBuilding, ICanProduce<Worker>
    {
        double x;
        double y;
        int hp = 2000;
        bool isDisabled = false;
        public string Name { get => "Командный центр"; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 4; }
        public int EnergyConsumption { get => 10;  }
        public int EnergyCost { get => 500; }
        public Player Team { get; set; }
        public double X { get; }
        public double Y { get; }
        public bool IsDisabled { get; }

        public CommandCenter(double x, double y)
        {
            this.y = y;
            this.x = x;
        }

        public void Consume()
        {
            if (!IsDisabled)
            {
                Team.Energy -= EnergyConsumption;
            }
        }

        public void Produce(Worker worker)
        {
            if (!IsDisabled)
            {
                int cost = worker.EnergyCost;
                if (Team.Energy >= cost)
                {
                    worker.Team = this.Team;
                    Team.Energy -= cost;
                    this.Consume();
                }
                else
                {
                    Console.WriteLine("Не хватает енергии");
                }
            }
        }

        public void Switch()
        {
            isDisabled = !isDisabled;
        }
    }
}
