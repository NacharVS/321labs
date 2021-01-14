using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    interface IUnit
    {
        string Name { get; set; }
        int Hp { get; set; }
        int Armor { get; set; }
    }
}
