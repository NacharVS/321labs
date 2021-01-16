using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Generator : IBuilding, IGenerator
    {

        int hp = 1000;
        bool isDisabled = false;
        public string Name { get => "Генератор"; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 4; }
        public int EnergyConsumption { get => 5; }
        public int EnergyCost { get => 200; }
        public Player Team { get; set; }
        public int X { get; }
        public int Y { get; }
        public int EnergyProduction { get => 25; }
        public bool IsDisabled { get; }

        public void Consume()
        {
            if (!IsDisabled)
            {
                Team.Energy -= EnergyConsumption;
            }
        }

        public void Generate()
        {
            if (!IsDisabled)
            {
                Team.Energy += EnergyProduction;
            }
        }
        public void Switch()
        {
            isDisabled = !isDisabled;
        }
    }
}
