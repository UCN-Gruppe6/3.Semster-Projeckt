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
    public class Storage
    {
        [Key]
        [DataMember]
        public int StorageId { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int Capacity { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public double Price { get; set; }

        public Motherboard Motherboard { get; set; }
    }
}
