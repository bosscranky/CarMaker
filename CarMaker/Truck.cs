using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaker
{
    public class Truck : BaseAutomobile<DieselEngine, ManualTransmission>
    {
        public bool FourWheelDrive { get; } = true;
        public Truck(ManualTransmission gearbox, DieselEngine icu) : base(gearbox, icu)
        {
        }
    }
}
