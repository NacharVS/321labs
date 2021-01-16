using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Gunner : ICanWalk, ICanAttack
    {
        int x;
        int y;
        int hp = 80;
        public string Name { get => "Стрелок";  }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => 1;  }
        public int MovementSpeed { get => 3;  }
        public int Damage { get => 10;  }
        public double TimeBetweenAttacks { get => 0.5;  }
        public int EnergyCost { get => 60; }
        public int AttackRange { get => 5;  }
        public int X { get; }
        public int Y { get; }
        public Player Team { get; set; }

        public void Attack(IUnit attacked) //attacked = атакуемый (тот кого будет атаковать)
        {
            //Если у юнита атака не достаёт до цели то он пойдёт к ней в плотную
            if (Distance(attacked.X, attacked.Y) <= this.AttackRange)
            {
                attacked.Hp -= this.Damage - attacked.Armor;
            }
            else
            {
                MoveTo(attacked.X, attacked.Y); 
            }
        }

        public double MoveTo(int x, int y)
        {
            double timeToTravel = Distance(x, y) / MovementSpeed;
            return timeToTravel;
        }
        public double Distance(int x, int y)
        {
            int destX = (int)Math.Pow(x - this.x, 2);
            int destY = (int)Math.Pow(y - this.y, 2);
            return Math.Sqrt(destX + destY);
        }
    }
}
