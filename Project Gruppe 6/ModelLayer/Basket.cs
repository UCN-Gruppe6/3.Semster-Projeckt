using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using System.Runtime.Serialization;

namespace ModelLayer
{ 
   [DataContract]
   public class Basket
    {

        [DataMember]
        public int BasketID { get; set; }
        [DataMember]
        public Computer_Case MyComputerCase { get; set; }
        [DataMember]
        public CPU MyCpu { get; set; }
        [DataMember]
        public GPU MyGpu { get; set; }
        [DataMember]
        public Motherboard MyMotherboard { get; set; }
        [DataMember]
        public RAM MyRam { get; set; }
        [DataMember]
        public Storage MyStorage { get; set; }

        //Add customer to the buy
        [DataMember]
        public Customer MyCustomer { get; set; }

    }

}
