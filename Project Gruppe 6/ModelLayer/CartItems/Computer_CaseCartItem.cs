using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLayer.CartItems
{
    public class Computer_CaseCartItem
    {
        [Key]
        public int ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public int CaseId { get; set; }

        public virtual Computer_Case Computer_Case { get; set; }
    }
}
