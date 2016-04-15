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
    public class GPU
    {
        [Key]
        [DataMember]
        public int GPUId { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public string Boardpartner { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int VRamAmount { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public double Price { get; set; }

        public Motherboard GMotherboard { get; set; }
    }
}
