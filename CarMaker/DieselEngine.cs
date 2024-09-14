using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaker
{
    public class DieselEngine : BaseEngine
    {
        public bool SuperCharged { get; }

        public DieselEngine()
        {
            SuperCharged = true;
            NumberOfCylinders = 12;
        }
    }
}
