using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Hardware
{
    public class Storage
    {
        public int StorageId { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
