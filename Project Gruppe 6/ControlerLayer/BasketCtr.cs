using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using DBLayer;
using ModelLayer.Basket;

namespace ControlerLayer
{
   public  class BasketCtr
    {

        public void CreateBasket(Basket basket)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Baskets.Add(basket);
                db.SaveChanges();
            }
        }

    }
}
