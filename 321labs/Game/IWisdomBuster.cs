using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface IWisdomBuster
    {
         public int Cost { get;set; }
         public void LVLUpUnit(Unit unit);
         
    }
}
