using System;
using System.Collections.Generic;

namespace _321labs.LabGame.Base
{
    public interface IScan
    {
        public abstract float Sense { get; set; }
        public abstract List<Unit> ScanAround();
    }
}
