using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    interface ICommonUnit
    {
        double Cost { get; set; }
        string Name { get; set; }
        int Hp { get; set; }
        int Strenght { get; set; }
        bool IsMove { get; set; }
        int Armor { get; set; }
        double Evasion { get; set; }
    }
}
