using System;
using System.Numerics;
using System.Collections.Generic;
using _321labs.LabGame.Base;

namespace _321labs.LabGame.Heroes
{
    class Cleric:Unit,IMoveable,IScan,IHealer
    {
        private int hp;
        private int maxHp;
        private float defCoef = 0.01f;
        public override string Name { get; set; } = "Безымянный юнит";
        public override Vector2 UnitPosition { get; set; }
        public override int HealthPoints
        {
            get => hp;
            set
            {
                hp = Math.Clamp(value, 0, maxHp);
            }
        }
        public override int MaxHeathPoints
        {
            get => maxHp;
            set
            {
                maxHp = Math.Max(value, 0);

            }
        }

        public override int Defense { get; set; }


        public override float Range { get; set; }
        public override float Size { get; set; }
        public float Speed { get; set; }
        public float Sense { get; set; }
        public override float Stealth { get; set; }
        public int HealZoneSize { get; set; }
        public int HealStr { get; set; }


        // Все настройки Unit
        public Cleric(Vector2 UnitPosition)
        {
            units.Add(this);
            this.UnitPosition = UnitPosition;
        }
        public Cleric(Vector2 UnitPosition, float Size) : this(UnitPosition)
        {
            this.Size = Size;
        }
        public Cleric(Vector2 UnitPosition, float Size, string Name) : this(UnitPosition, Size)
        {
            this.Name = Name;
        }
        public Cleric(Vector2 UnitPosition, float Size, string Name, int HealthPoints) : this(UnitPosition, Size, Name)
        {
            this.HealthPoints = HealthPoints;
        }
        public Cleric(Vector2 UnitPosition, float Size, string Name, int HealthPoints, int Defense) : this(UnitPosition, Size, Name, HealthPoints)
        {
            this.Defense = Defense;
        }
        public Cleric(Vector2 UnitPosition, float Size, string Name, int HealthPoints, int Defense, float Stealth) : this(UnitPosition, Size, Name, HealthPoints, Defense)
        {
            this.Stealth = Stealth;
        }
        public Cleric(Vector2 UnitPosition, float Size, string Name, int HealthPoints, int Defense, float Stealth, float Range) : this(UnitPosition, Size, Name, HealthPoints, Defense, Stealth)
        {
            this.Range = Range;
        }
        // Все настройки Cleric
        public Cleric(Vector2 UnitPosition, float Size, string Name, int HealthPoints, int Defense, float Stealth, float Range,int HealZoneSize = 1, int HealStr = 1, float Speed = 1, float Sense = 1) : this(UnitPosition, Size, Name, HealthPoints, Defense, Stealth, Range)
        {
            this.HealStr = HealStr;
            this.HealZoneSize = HealZoneSize;
            this.Speed = Speed;
            this.Sense = Sense;
        }

        public bool CanMoveToPoint(Vector2 position)
        {
            //Не занята ли наша точка каким либо юнитом?
            if (units.Find((unit) => ToPointDist(unit.UnitPosition) - (unit.Size) > 0 && unit != this) == null)
                return true;
            else
                return false;
        }

        public override bool InRange(Vector2 position)
        {
            //Дистанция до точка
            float dist = ToPointDist(position);

            //Находится ли точка в досягаемости нашего юнита?
            if (dist < Range)
                return true;
            else
                return false;
        }

        public override bool InSize(Vector2 position)
        {
            //Дистанция до точки
            float dist = ToPointDist(position);

            //Находится ли точка внутри нашего юнита?
            if (dist < Size)
                return true;
            else
                return false;
        }

        public List<Unit> ScanAround()
        {
            Console.WriteLine($"{Name} осмотрелся вокруг и увидел:");

            //Поиск всех юнитов что находятся в радиусе чувствительности персонажей с учетом скрытности
            List<Unit> sensedUnits = units.FindAll((unit) => Math.Pow(unit.UnitPosition.X - UnitPosition.X, 2) + Math.Pow(unit.UnitPosition.Y - UnitPosition.Y, 2) <= Math.Pow(Sense - unit.Stealth, 2) && unit != this);

            foreach (Unit unit in sensedUnits)
            {
                Console.WriteLine(unit.ScanInfo());
            }

            return sensedUnits;
        }

        public override string ScanInfo()
        {
            return new String('_', Name.Length + GetType().Name.Length + 2) + "\n" +
                $" {GetType().Name} - {Name} \n" +
                $" На позиции: " +
                $" X:{UnitPosition.X} Y:{UnitPosition.Y} \n" +
                new String('_', Name.Length + GetType().Name.Length + 2);
        }

        public float ToPointDist(Vector2 position)
        {
            return (float)Math.Sqrt(Math.Pow((position.X - UnitPosition.X), 2) + Math.Pow((position.Y - UnitPosition.Y), 2));
        }
        public void MoveToPoint(Vector2 position)
        {
            if (!CanMoveToPoint(position)) return;
            UnitPosition = Vector2.Add(UnitPosition, Vector2.Normalize(Vector2.Subtract(position, UnitPosition)) * (Math.Clamp(Speed, 0, ToPointDist(position))));
        }

        public override void GetDamage(int Damage)
        {
            float Damaged = Math.Max(Damage - Defense * defCoef, 0);
            HealthPoints -= (int)Damaged;
        }

        public override void GetHeal(int Heal)
        {
            HealthPoints += Heal;
        }

        public void HealToPoint(Vector2 position)
        {
            if (!InRange(position)) return;
            List<Unit> HealedUnits = units.FindAll((unit) => this.InHealZone(position,unit.UnitPosition));
            if (HealedUnits != null)
            {
                foreach (Unit u in HealedUnits)
                {
                    u.GetHeal(HealStr);
                }
            }
        }

        public bool InHealZone(Vector2 healPosition,Vector2 position)
        {
            return (float)Math.Sqrt(Math.Pow((healPosition.X - position.X), 2) + Math.Pow((healPosition.Y - position.Y), 2))<HealZoneSize;
        }
    }
}
