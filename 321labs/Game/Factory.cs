using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Factory : IBuilding, ICanProduce<ICanAttack>
    {
        int hp = 1500;
        bool isDisabled = false;
        public string Name { get => "Фабрика"; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 4; }
        public int EnergyConsumption { get => 5; }
        public int EnergyCost { get => 150; }
        public Player Team { get; set; }
        public int X { get; }
        public int Y { get; }
        public bool IsDisabled { get; }

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
