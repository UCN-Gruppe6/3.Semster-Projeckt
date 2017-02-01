using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using ModelLayer;
using System.Transactions;

namespace ControlerLayer
{
    public class BasketCtr
    {
        private HardwererCtr hCtr = new HardwererCtr();
        private MailBot.MailBot MailRobot = new MailBot.MailBot();

        public void BuyBasket(Basket basket)
        {
            try
            {
                CreateBasketTransaction(basket);
            }
            catch
            {
                throw new Exception("Købet gik ikke igennem");
            }   
        }

        private void CreateBasketTransaction(Basket basket)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (var db = new EntityFrameworkContext())
                {
                    
                    if (basket.MyCpu != null)
                    {
                        basket.MyCpu = db.CPUs.Find(basket.MyCpu.CPUId);
                        if (basket.MyCpu.Stock > 0)
                        {
                            basket.MyCpu.Stock--;
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("CPU'en er ikke på lager merer.");
                        }
                    }
                    if (basket.MyGpu != null)
                    {
                        basket.MyGpu = db.GPUs.Find(basket.MyGpu.GPUId);
                        if (basket.MyGpu.Stock > 0)
                        {
                            basket.MyGpu.Stock--;
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("GPU'en er ikke på lager merer.");
                        }
                    }
                    if (basket.MyRam != null)
                    {
                        basket.MyRam = db.RAMs.Find(basket.MyRam.RAMId);
                        if (basket.MyRam.Stock > 0)
                        {
                            basket.MyRam.Stock--;
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("RAMne er ikke på lager mere.");
                        }
                    }
                    if (basket.MyMotherboard != null)
                    {
                        basket.MyMotherboard = db.Motherboards.Find(basket.MyMotherboard.MotherboardId);
                        if (basket.MyMotherboard.Stock > 0)
                        {
                            basket.MyMotherboard.Stock--;
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Bundkortet er ikke på lager merer.");
                        }
                    }
                    if (basket.MyComputerCase != null)
                    {
                        basket.MyComputerCase = db.CompunterCase.Find(basket.MyComputerCase.CaseId);
                        if (basket.MyComputerCase.Stock > 0)
                        {
                            basket.MyComputerCase.Stock--;
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Kabenittet er ikke på lager merer");
                        }
                    }
                    if (basket.MyStorage != null)
                    {
                        basket.MyStorage = db.Storages.Find(basket.MyStorage.StorageId);
                        if (basket.MyStorage.Stock > 0)
                        {
                            basket.MyStorage.Stock--;
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("HDD/SSD'en er ikke på lager merer");
                        }
                    }
                    if(basket.MyCustomer != null)
                    {
                        MailRobot.SendInvoiceMail(basket);
                    }

                    db.Baskets.Add(basket);

                    try
                    {
                        db.SaveChanges();
                        scope.Complete();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }
    }
}
