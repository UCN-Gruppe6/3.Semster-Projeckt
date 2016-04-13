﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Hardware
{
    [DataContract]
    public class Motherboard
    {
        [Key]
        public int MotherboardId { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public string Chipset { get; set; }
        [DataMember, MaxLength(100)]
        public string Description { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public double Price { get; set; }

        public Socket SocketType { get; set; }
    }
}
