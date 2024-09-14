using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaker
{
    public class ManualTransmission : BaseTransmission
    {
        public ManualTransmission()
        {
            Manual = true;
            NumberOfSpeeds = 6;
        }
    }
}
