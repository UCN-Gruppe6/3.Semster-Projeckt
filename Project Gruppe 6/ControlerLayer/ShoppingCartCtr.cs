using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.CartItems;
using DBLayer;
using ControlerLayer;

namespace ControlerLayer
{
    public class ShoppingCartCtr
    {
        public string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";

        public int AddCPUtoCart (CPUCartItem cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                var cpuItem = db.CPUtoBUY.SingleOrDefault(c => c.CartId = ShoppingCartId && c.CPUId = cpu.CPUId);
            }
        }
    }
}
