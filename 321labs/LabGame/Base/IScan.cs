using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.LabGame.Base
{
    public interface IScan
    {
        public abstract int Sense { get; set; }
        public abstract List<Unit> ScanAround();
    }
}
