using System;

namespace _321labs.Fedotov.Game.Unit
{
    class Swordsman : IUnit, IMove, IAttack
    {
        public Guid id { get; set; }
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int SpeedMove { get; set; }
        public int AgilityMove { get; set; }
        public int Damage { get; set; }

        public void StopMove()
        {
            Console.WriteLine("Мечник стоит");
        }

        public void StartMove()
        {
            Console.WriteLine("Мечник идет");
        }

        public Weapon weapon { get; set; }

        public void TakeDamage()
        {
            Console.WriteLine("Удар мечом");
        }
    }
}
