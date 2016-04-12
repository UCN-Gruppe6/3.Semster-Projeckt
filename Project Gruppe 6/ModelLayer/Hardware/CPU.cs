using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Hardware
{
    public class CPU
    {
        public string Brand { get; set; }
        public string ModelNumber { get; set; }
        public double BaseClock { get; set; }
        public double BoostClock { get; set; }
        public bool IsUnlocked { get; set; }
        public string Description { get; set; }
    }
}
