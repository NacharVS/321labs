using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface Unit
    {
        public int Health
        {
            get;
            set;
        }
        public int MoveSpeed
        {
            get;
            set;
        }
        public int Vision
        {
            get;
            set;
        }
        public int NightVision
        {
            get;
            set;
        }

    }
}
