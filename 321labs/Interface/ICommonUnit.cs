using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    interface ICommonUnit
    {
        string TypeUnit { get; }
        double Cost { get; set; }
        string Name { get; set; }
        int Hp { get; set; }
        int Strenght { get; set; }
        int Armor { get; set; }
        double Evasion { get; set; }
        void Attack();
        void Display();
    }
}
