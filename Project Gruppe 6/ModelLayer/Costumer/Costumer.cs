using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    // En klasse til kunder. 

    [DataContract]
    public class Costumer
    {
        [DataMember]
        public int CostumerId { get; set; } // Primary key

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime? Birthday { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int ZIPCode { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public int PhoneNumber { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Company { get; set; }
    }
}
