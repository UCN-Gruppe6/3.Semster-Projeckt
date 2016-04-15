﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLayer.Hardware
{
    [DataContract]
    public class Socket
    {
        [Key]
        public int Id { get; set; }
        [DataMember, MaxLength(10), Required]
        public string SocketType { get; set; }
        [DataMember]
        public string Architecture { get; set; }

        public CPU CPU { get; set; }
        [ForeignKey("CPU")]
        public int CPUId { get; set; }

        public Motherboard Motherboard { get; set; }
        [ForeignKey("Motherboard")]
        public int MotherboardId { get; set; }

        public List<CPU> CPUs { get; set; }
        public List<Motherboard> Motherboards { get; set; }

    }
}
