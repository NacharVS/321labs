using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface IUnit
    {
        double X { get; }
        double Y { get; }
        string Name { get; }
        int Hp { get; set; }
        int Armor { get; }
        int EnergyCost { get; }
        Player Team { get; set; }
    }
}
