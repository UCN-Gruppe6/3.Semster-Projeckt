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
        public double BaseClok { get; set; }
        public double BoostClok { get; set; }
        public bool IsUnkockt { get; set; }
        public string Description { get; set; }
    }
}
