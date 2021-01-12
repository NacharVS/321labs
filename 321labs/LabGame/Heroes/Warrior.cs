using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using _321labs.LabGame.Base;
using System.Drawing;

namespace _321labs.LabGame.Heroes
{
    class Warrior : Unit, IMoveable, IScan, IAttacker
    {
        public override string Name { get; set; }
        public override Vector2 UnitPosition { get; set; }
        public override int HealthPoint { get; set; }
        public override int Defense { get; set ; }
        public override double Range { get; set; }
        public override double Size { get; set; }
        public override Color Color { get; set; }
        public float Speed { get; set; }
        public int Sense { get; set; }
        public int Attack { get; set; }


        public void AttackToPoint(Vector2 position)
        {
            throw new NotImplementedException();
        }

        public bool CanMoveToPoint(Vector2 position)
        {
            //Не занята ли наша точка каким либо юнитом?
            if (units.Find((unit) => unit.InSize(position)) == null)
                return true;
            else 
                return false;
        }
        public override bool InRange(Vector2 position)
        {
            //Дистанция до точка
            double dist = Math.Sqrt(Math.Pow((position.X - UnitPosition.X), 2) + Math.Pow((position.Y - UnitPosition.Y), 2));

           //Находится ли точка в досягаемости нашего юнита?
            if (dist < Range)
                return true;
            else 
                return false;
        }

        public override bool InSize(Vector2 position)
        {
            //Дистанция до точки
            double dist = Math.Sqrt(Math.Pow((position.X - UnitPosition.X), 2) + Math.Pow((position.Y - UnitPosition.Y), 2));

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
            List <Unit> sensedUnits = units.FindAll((unit) => Math.Pow(unit.UnitPosition.X - UnitPosition.X, 2) + Math.Pow(unit.UnitPosition.Y - UnitPosition.Y, 2) <= Math.Pow(Sense-unit.Stealth, 2));
            
            foreach (Unit unit in sensedUnits)
            {
                unit.ScanInfo();
            }

            return sensedUnits;
        }

        void IMoveable.MoveToPoint(Vector2 position)
        {
            if (!CanMoveToPoint(position)) return;
            UnitPosition = Vector2.Lerp(UnitPosition, position, Speed);
        }
    }
}
