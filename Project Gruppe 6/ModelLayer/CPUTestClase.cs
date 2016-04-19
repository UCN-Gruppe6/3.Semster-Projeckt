using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class CPUTestClase
    {
        [Key]
        public int CPUTestClasId { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Category { get; set; }
    }
}
