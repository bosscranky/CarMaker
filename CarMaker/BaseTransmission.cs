using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaker
{
    public class BaseTransmission
    {
        public int NumberOfSpeeds { get; set; }


        /// <summary>
        /// this would probably be represented with a sub-class of transmission
        /// </summary>
        public bool Manual { get; set; }

        public bool InGear { get; set; }
    }
}
