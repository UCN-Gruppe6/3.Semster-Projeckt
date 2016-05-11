using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using ModelLayer;

namespace ModelLayer.Basket
{ 
   public class Basket
    {
        public Computer_Case MyComputerCase { get; set; }
        public CPU MyCpu { get; set; }
        public GPU MyGpu { get; set; }
        public Motherboard MyMotherboard { get; set; }
        public RAM MyRam { get; set; }
        public Storage MyStorage { get; set; }

        //Add customer to the buy
        public Customer MyCustomer { get; set; }
    }

}
