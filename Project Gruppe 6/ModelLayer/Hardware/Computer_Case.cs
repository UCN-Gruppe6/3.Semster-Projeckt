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
    public class Computer_Case
    {
        [Key]
        [DataMember]
        public int CaseId { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Category { get; set; }

        public Motherboard CMotherboard { get; set; }

        [DataMember]
        public int Stock { get; set; }
    }
}
