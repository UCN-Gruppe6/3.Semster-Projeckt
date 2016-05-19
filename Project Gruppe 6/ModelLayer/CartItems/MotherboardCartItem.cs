﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.Hardware;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLayer.CartItems
{
    public class MotherboardCartItem
    {
        [Key]
        public int ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public int MotherboardId { get; set; }

        public virtual Motherboard Motherboard { get; set; }
    }
}
