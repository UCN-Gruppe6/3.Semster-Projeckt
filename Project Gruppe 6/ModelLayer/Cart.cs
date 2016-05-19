using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.CartItems;


namespace ModelLayer
{
    public class Cart
    {
        public int ID { get; set; }
        public string CartId { get; set; }

        public int CPUId { get; set; }
        public CPUCartItem CPU { get; set; }

        public int GPUId { get; set; }
        public GPUCartItem GPU { get; set; }

        public int RAMId { get; set; }
        public RAMCartItem RAM { get; set; }

        public int 
    }
}
