using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Factory : IBuilding, ICanProduce<ICanAttack>
    {
        double x;
        double y;
        int hp = 1500;
        bool isDisabled = false;
        bool isDestroed = false;
        public string Name { get => "Фабрика"; }
        public int Hp
        {
            get { return hp; }
            set
            {
                hp = value;
                if (hp <= 0)
                {
                    isDestroed = true;
                }
            }
        }
        public bool IsDestroed { get; }
        public int Armor { get => 4; }
        public int EnergyConsumption { get => 5; }
        public int EnergyCost { get => 150; }
        public Player Team { get; set; }
        public double X { get; }
        public double Y { get; }
        public bool IsDisabled { get; }

        public Factory(double x, double y)
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

        public void Produce(ICanAttack unit)
        {
            if (!IsDisabled)
            {
                int cost = unit.EnergyCost;
                if (Team.Energy >= cost)
                {
                    unit.Team = this.Team;
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
