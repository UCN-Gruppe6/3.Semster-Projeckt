using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;
using ModelLayer.Hardware;
using ModelLayer.CartItems;

namespace ControlerLayer
{
    public class ShoppingCartCtr
    {
        public string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";

        public int AddCPUtoCart(CPUCartItem cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {

            }
        }
    }
}
