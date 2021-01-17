using System;
using System.Numerics;

namespace _321labs.LabGame.Base
{
    interface IUpgrader
    {
        public float UpgradeCoef { get; set; }
        public float UpgradeCost { get; set; }
        public void Upgrade(Vector2 position);
    }
}
