using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaker
{
    public class SportEngine : BaseEngine
    {
        public bool TurboCharged { get; }

        public SportEngine()
        { 
            TurboCharged = true;
            NumberOfCylinders = 8;
        }
    }
}
