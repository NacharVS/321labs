using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class WisdomCastle : Unit, IWisdomBuster
    {
        protected override int PowerCoef { get; } = 4;
        protected override int AggilityCoef { get; } = 0;
        protected override int DefenseCoef { get; } = 2;
        protected override int MaxHealthCoef { get; } = 20;

        private int _lvl=1;
        private int _healthPoint;
        private int _exPoint;
        public override string Name { get; set; }
        public override int LVL { get => _lvl; set => Math.Max(value, 1); }
        public override int Exp { get => _exPoint; set => Math.Max(value, 0); }
        public override int MaxHealth => Power * MaxHealthCoef;
        public override int Health { get => _healthPoint; set => _healthPoint = Math.Clamp(value, 0, MaxHealth); }
        public override int Power => LVL * PowerCoef;
        public override int Aggility => LVL * AggilityCoef;
        public override int Defense => LVL * DefenseCoef;

        public int Cost { get; set; } = 10;

        public WisdomCastle(string Name, int LVL,int Cost) : base(LVL, Name) { this.Cost = Cost; }
        public override void GetDamage(int Damage)
        {
            Health -= (Math.Max(Damage - Defense, 0));
        }

        public void LVLUpUnit(Unit unit)
        {
            if (unit.Exp>=Cost)
            {
                unit.LVL++;
                unit.Exp -= Cost;
            }
             
        }

        
    }
}
