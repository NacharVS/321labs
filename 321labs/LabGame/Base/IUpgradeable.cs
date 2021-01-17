using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.LabGame.Base
{
    interface IUpgradeable
    {
        public float Cost { get; set; }
        public float CostRizeCoef { get; set; }
        public void Upgrade();
        public void CanUpgrade();
    }
}
