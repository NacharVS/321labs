using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.LabGame.Base
{
    static class Player
    {
        private static float _money = 0;
        public static float Money { get => _money; set { _money = Math.Max(value, 0); } }
    }
}
