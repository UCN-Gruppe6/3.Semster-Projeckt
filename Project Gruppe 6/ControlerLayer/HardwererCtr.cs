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
    // Denne her ctr bluver kun brugt til at finde hardware
    public class HardwererCtr
    {

        //CPU CTR
        #region

        public IEnumerable<CPU> FindCPUsByBrand(string brand)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.Where(x => x.Brand.Equals(brand)).ToList();
            }
        }

        public IEnumerable<CPU> FindCPUsByCategory(string category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.Where(x => x.Category.Equals(category)).ToList();
            }
        }

        public IEnumerable<CPU> FindAllCPUs()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.ToList();
            }
        }

        public CPU FindCPUbyModelNr(string modelNr)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.Where(x => x.ModelNumber.Equals(modelNr)).FirstOrDefault();
            }
        }

        public CPU FindCPUbyID(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.Find(id);
            }
        }

        // bliver ikke brugt så tit
        public Socket FindSocket(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Sockets.Find(id);
            }
        }

        #endregion

        //Storage CTR
        #region 
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
        #endregion

        //RAM CTR
        #region
        public IEnumerable<RAM> FindRamByManufacturer(string Manufacturer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.RAMs.Where(x => x.Manufacturer.Equals(Manufacturer)).ToList();
            }
        }
        public IEnumerable<RAM> FindRamByCategory(string Category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.RAMs.Where(x => x.Category.Equals(Category)).ToList();
            }
        }
        public IEnumerable<RAM> FindAllRam()
        {
            using(EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.RAMs.ToList();
            }
        }
        #endregion

        //MotherBoard CTR
        #region
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
        #endregion

        //GPU CTR
        #region
        public IEnumerable<GPU> FindGpuByManufacturer(string Manufacturer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.Where(x => x.Manufacturer.Equals(Manufacturer)).ToList();
            }
        }
        public IEnumerable<GPU> FindGpuByModel(string Model)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.Where(x => x.Model.Equals(Model)).ToList();
            }
        }
        public IEnumerable<GPU> FindGpuByCategory(String Category)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.Where(x => x.Category.Equals(Category)).ToList();
            }
        }
        public IEnumerable<GPU> FindAllGpus()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.GPUs.ToList();
            }
        }
        #endregion

        //Computer Case CTR
        #region
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
        #endregion


        // Test method. Bliver kun brugt til at teste med. 
        public IEnumerable<CPUTestClase> FindAllCPUs2()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUTestClas.ToList();
            }
        }
    }
}
