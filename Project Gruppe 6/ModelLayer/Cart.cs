using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.CartItems;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        public string CartId { get; set; }

        public int CPUId { get; set; }
        public CPUCartItem CPU { get; set; }

        public int GPUId { get; set; }
        public GPUCartItem GPU { get; set; }

        public int RAMId { get; set; }
        public RAMCartItem RAM { get; set; }

        public int MotherboardId { get; set; }
        public MotherboardCartItem Motherboard { get; set; }

        public int StorageId { get; set; }
        public StorageCartItem Storage { get; set; }

        public int CaseId { get; set; }
        public Computer_CaseCartItem Case { get; set; }
    }
}
