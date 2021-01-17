﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface ICanWalk : IUnit
    {
        int MovementSpeed { get;  }

        void MoveTo(double x, double y);
    }
}
