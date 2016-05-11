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
    public class CPU
    {
        [DataMember]
        public int CPUId { get; set; } // Primary key

        [DataMember, MaxLength(10) ]
        public string Brand { get; set; }

        [DataMember]
        public string ModelNumber { get; set; }

        [DataMember]
        public double BaseClock { get; set; }

        [DataMember]
        public double BoostClock { get; set; }

        [DataMember]
        public bool IsUnlocked { get; set; }

        [DataMember, MaxLength(50)]
        public string Description { get; set; }

        [DataMember]
        public Socket Socket { get; set; }
        public int SocketId { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public int Stock { get; set; }

    }
}
