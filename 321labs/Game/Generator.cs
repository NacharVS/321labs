using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Generator : IBuilding, IGenerator
    {
        double x;
        double y;
        int hp = 1000;
        bool isDisabled = false;
        bool isDestroed = false;
        public string Name { get => "Генератор"; }
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
        public int EnergyCost { get => 200; }
        public Player Team { get; set; }
        public double X { get; }
        public double Y { get; }
        public int EnergyProduction { get => 25; }
        public bool IsDisabled { get; }

        public Generator(double x, double y)
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

        public void Generate()
        {
            if (!IsDisabled)
            {
                Team.Energy += EnergyProduction;
                this.Consume();
            }
        }
        public void Switch()
        {
            isDisabled = !isDisabled;
        }
    }
}
