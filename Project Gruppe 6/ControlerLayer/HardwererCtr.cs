using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DBLayer;
using ModelLayer.Hardware;

namespace ControlerLayer
{
    // Dette her er conttolern til hardwerer.
    // Det er KUN CPU der har create og delete metoder.
    // Alle andre update metoder bliver lige nu kund brugt til at trække fra i stock når man køber noget.
    public class HardwererCtr
    {
        //Alle metoder til CPU
        #region CPU Ctr

        // Metode til at finde alle CPU'er i databasen via brand.
        public IEnumerable<CPU> FindCPUsByBrand(string brand)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.Where(x => x.Brand.Equals(brand)).ToList();
            }
        }

        // Metode til at finde alle CPU'er via katakori.
        public IEnumerable<CPU> FindCPUsByCategory(string category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.Where(x => x.Category.Equals(category)).ToList();
            }
        }

        // Finder alle CPU'er i databasen.
        public IEnumerable<CPU> FindAllCPUs()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.ToList();
            }
        }

        // Finder en bestemt CPU i databasen via et id.
        public CPU FindCPUbyID(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.Find(id);
            }
        }

        // Finder en socket i databasen.
        // Bliver kun brugt til at lave en CPU.
        // Er lavet på forhånd så der er ingen create, update eller delete metode til den.
        public Socket FindSocket(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Sockets.Find(id);
            }
        }

        // Metode til at lave en ny CPU.
        public void CreateCPU(CPU cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.CPUs.Add(cpu);
                db.SaveChanges();
            }
        }

        // Metode til at updater en CPU.
        public void UpdateCPU(CPU cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(cpu).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // Metode til at slætte en CPU via id.
        public void DeleteCPU(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                CPU cpu = new CPU();
                cpu.CPUId = id;
                db.Entry(cpu).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        #endregion

        //Alle metoder til HDD/SSD
        #region Storage Ctr

        public IEnumerable<Storage> FindStorageByManufacturer(string Manufacturer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Storages.Where(x => x.Manufacturer.Equals(Manufacturer)).ToList();
            }
        }
        public IEnumerable<Storage> FindStorageByCategory(string Category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Storages.Where(x => x.Category.Equals(Category)).ToList();
            }
        }
        public IEnumerable<Storage> FindAllStorage()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Storages.ToList();
            }
        }

        public Storage FindStorageById (int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Storages.Find(id);
            }
        }

        public void UpdateStorage (Storage storage)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(storage).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        #endregion

        //Alle metoder til RAM
        #region RAM Ctr

        // Metode til finde alle RAM fra en bestemt manufacturer
        public IEnumerable<RAM> FindRamByManufacturer(string Manufacturer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.RAMs.Where(x => x.Manufacturer.Equals(Manufacturer)).ToList();
            }
        }

        // Metode til at finde alle RAM efter katakorig.
        public IEnumerable<RAM> FindRamByCategory(string Category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.RAMs.Where(x => x.Category.Equals(Category)).ToList();
            }
        }

        // Metode til at finde alle RAM.
        public IEnumerable<RAM> FindAllRam()
        {
            using(EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.RAMs.ToList();
            }
        }

        // Metode til at finde en bestemt RAM.
        public RAM FindRAMbyId(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.RAMs.Find(id);
            }
        }

        // Metode til at opdater RAM.
        public void UpdateRAM(RAM ram)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(ram).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        #endregion

        //Alle metoder til bundkort.
        #region Motherbord Ctr
        public IEnumerable<Motherboard> FindMotherboardByManufacturer(string Manufacturer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Motherboards.Where(x => x.Manufacturer.Equals(Manufacturer)).ToList();
            }
        }
        public IEnumerable<Motherboard> FindMotherboardByCategory(string Category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Motherboards.Where(x => x.Category.Equals(Category)).ToList();
            }
        }
        public IEnumerable<Motherboard> FindAllMotherboard()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Motherboards.ToList();
            }
        }

        public Motherboard FindMotherbordById(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Motherboards.Find(id);
            }
        }

        public void UpdateMotherbord(Motherboard motherbord)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(motherbord).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        #endregion

        //Alle metoder til GPU
        #region GPU Ctr

        // Metode til at finde alle GPU'er efter hvem der har lavet dem.
        public IEnumerable<GPU> FindGpuByManufacturer(string Manufacturer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.Where(x => x.Manufacturer.Equals(Manufacturer)).ToList();
            }
        }

        // Metode til at GPU'er efter ders model(eks. GTX 960 eller R9 380)
        public IEnumerable<GPU> FindGpuByModel(string Model)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.Where(x => x.Model.Equals(Model)).ToList();
            }
        }

        // Metode til at finde alle GPU'er efter katagorig.
        public IEnumerable<GPU> FindGpuByCategory(String Category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.Where(x => x.Category.Equals(Category)).ToList();
            }
        }

        // Finder alle GPU'er
        public IEnumerable<GPU> FindAllGpus()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.ToList();
            }
        }

        // Metode til at finde en GPU via id.
        public GPU FindGPUbyId(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.Find(id);
            }
        }

        // Metode til at opdater GPU.
        public void UpdateGPU(GPU gpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(gpu).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        #endregion

        //Alle metoder til kabeninet.
        #region Case Ctr

        public IEnumerable<Computer_Case> FindComputerCaseByManufacturer(string Manufacturer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CompunterCase.Where(x => x.Manufacturer.Equals(Manufacturer)).ToList();
            }
        }
        public IEnumerable<Computer_Case> FindComputerCaseByCategory(string Category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CompunterCase.Where(x => x.Category.Equals(Category)).ToList();
            }
        }
        public IEnumerable<Computer_Case> FindAllComputerCases()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CompunterCase.ToList();
            }
        }

        public Computer_Case FindCaseById(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CompunterCase.Find(id);
            }
        }

        public void UpdateCase(Computer_Case Ccase)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(Ccase).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        #endregion

    }
}
