using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Key]
        public Socket SocketType { get; set; }

        public List<GPU> GPUs { get; set; }

        public List<Storage> Stoprage { get; set; }

        public List<RAM> RAMs { get; set; }

        public List<Computer_Case> ComputerCase { get; set; }

            
        }
}
