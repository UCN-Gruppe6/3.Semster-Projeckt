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
                        db.Entry(basket.MyCpu).State = System.Data.Entity.EntityState.Modified;
                        var cpu = db.CPUs.Find(basket.MyCpu.CPUId);
                        if (cpu.Stock > 0)
                        {
                            cpu.Stock--;
                            hCtr.UpdateCPU(cpu);
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("CPU'en er ikke på lager merer.");
                        }
                    }
                    if (basket.MyGpu != null)
                    {
                        db.Entry(basket.MyGpu).State = System.Data.Entity.EntityState.Modified;
                        var gpu = db.GPUs.Find(basket.MyGpu.GPUId);
                        if (gpu.Stock > 0)
                        {
                            gpu.Stock--;
                            hCtr.UpdateGPU(gpu);
                            db.SaveChanges();
                        }
                        else if (gpu.Stock < 1)
                        {
                            throw new Exception("GPU'en er ikke på lager merer.");
                        }
                    }
                    if (basket.MyRam != null)
                    {
                        db.Entry(basket.MyRam).State = System.Data.Entity.EntityState.Modified;
                        var ram = db.RAMs.Find(basket.MyRam.RAMId);
                        if (ram.Stock > 0)
                        {
                            ram.Stock--;
                            hCtr.UpdateRAM(ram);
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("RAMne er ikke på lager mere.");
                        }
                    }
                    if (basket.MyMotherboard != null)
                    {
                        db.Entry(basket.MyMotherboard).State = System.Data.Entity.EntityState.Modified;
                        var motherbord = db.Motherboards.Find(basket.MyMotherboard.MotherboardId);
                        if (motherbord.Stock > 0)
                        {
                            motherbord.Stock--;
                            hCtr.UpdateMotherbord(motherbord);
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Bundkortet er ikke på lager merer.");
                        }
                    }
                    if (basket.MyComputerCase != null)
                    {
                        db.Entry(basket.MyComputerCase).State = System.Data.Entity.EntityState.Modified;
                        var Ccase = db.CompunterCase.Find(basket.MyComputerCase);
                        if (Ccase.Stock > 0)
                        {
                            Ccase.Stock--;
                            hCtr.UpdateCase(Ccase);
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Kabenittet er ikke på lager merer");
                        }
                    }
                    if (basket.MyStorage != null)
                    {
                        db.Entry(basket.MyStorage).State = System.Data.Entity.EntityState.Modified;
                        var storage = db.Storages.Find(basket.MyStorage.StorageId);
                        if (storage.Stock > 0)
                        {
                            storage.Stock--;
                            hCtr.UpdateStorage(storage);
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
