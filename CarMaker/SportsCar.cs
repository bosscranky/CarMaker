using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaker
{
    public class SportsCar : BaseAutomobile<SportEngine, ManualTransmission>
    {
        public SportsCar(ManualTransmission gearbox, SportEngine icu) : base(gearbox, icu)
        {
        }
    }
}
