using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Hardware
{
    [DataContract]
    public class CPU
    {
        [Key]
        public int id { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string ModelNumber { get; set; }
        [DataMember]
        public double BaseClock { get; set; }
        [DataMember]
        public double BoostClock { get; set; }
        [DataMember]
        public bool IsUnlocked { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
