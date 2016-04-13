using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Hardware
{
    public class GPU
    {
        public int GPUId { get; set; }
        public string Manufacturer { get; set; }
        public string Boardpartner { get; set; }
        public string Model { get; set; }
        public int VRamAmount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
