using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.Hardware;
using ControlerLayer;
using ModelLayer.Basket;

namespace WCFServices 
{
    public class PcPartService : IPcPartService
    {

        private HardwererCtr HWCtr = new HardwererCtr();
        private CustomerCtr customerCtr = new CustomerCtr();
        private BasketCtr basketctr = new BasketCtr();

        // Hardware
        #region

        #region CPU
        // CPU START 
        public IEnumerable<CPU> FindAllCPUs()
        {
            return HWCtr.FindAllCPUs();
        }

        public IEnumerable<CPU> FindCPUsByBrand(string Brand)
        {
            return HWCtr.FindCPUsByBrand(Brand);
        }

        public IEnumerable<CPU> FindCPUsByCategory(string Category)
        {
            return HWCtr.FindCPUsByCategory(Category);
        }

        public CPU FindCPUbyId (int id)
        {
            return HWCtr.FindCPUbyID(id);
        }

        public void CreateCPU(CPU cpu)
        {
            HWCtr.CreateCPU(cpu);
        }

        public void UpdateCPU(CPU cpu)
        {
            HWCtr.UpdateCPU(cpu);
        }

        public void DeleteCPU(int id)
        {
            HWCtr.DeleteCPU(id);
        }

        public Socket FindSocket(int id)
        {
            return HWCtr.FindSocket(id);
        }

        #endregion

        #region Storage

        public IEnumerable<Storage> FindAllStorage()
        {
            return HWCtr.FindAllStorage();
        }
        public IEnumerable<Storage> FindStorageByCategory(string Category)
        {
            return HWCtr.FindStorageByCategory(Category);
        }

        public IEnumerable<Storage> FindStorageByManufacturer(string Manufacturer)
        {
            return HWCtr.FindStorageByManufacturer(Manufacturer);
        }

        public Storage FindStorageById(int id)
        {
            return HWCtr.FindStorageById(id);
        }

        public void UpdateStorage(Storage storage)
        {
            HWCtr.UpdateStorage(storage);
        }

        #endregion

        #region RAM

        public IEnumerable<RAM> FindAllRam()
        {
            return HWCtr.FindAllRam();
        }
        public IEnumerable<RAM> FindRamByCategory(string Category)
        {
            return HWCtr.FindRamByCategory(Category);
        }

        public IEnumerable<RAM> FindRamByManufacturer(string Manufacturer)
        {
            return HWCtr.FindRamByManufacturer(Manufacturer);
        }

        public RAM FindRAMbyId(int id)
        {
            return HWCtr.FindRAMbyId(id);
        }

        public void UpdateRAM(RAM ram)
        {
            HWCtr.UpdateRAM(ram);
        }

        #endregion

        #region Motherbord

        public IEnumerable<Motherboard> FindAllMotherboard()
        {
            return HWCtr.FindAllMotherboard();
        }
        public IEnumerable<Motherboard> FindMotherboardByCategory(string Category)
        {
            return HWCtr.FindMotherboardByCategory(Category);
        }

        public IEnumerable<Motherboard> FindMotherboardByManufacturer(string Manufacturer)
        {
            return HWCtr.FindMotherboardByManufacturer(Manufacturer);
        }

        public Motherboard FindMotherbordById(int id)
        {
            return HWCtr.FindMotherbordById(id);
        }

        public void UpdateMotherbord(Motherboard motherbord)
        {
            HWCtr.UpdateMotherbord(motherbord);
        }

        #endregion

        #region GPU

        public IEnumerable<GPU> FindAllGpus()
        {
            return HWCtr.FindAllGpus();
        }
        public IEnumerable<GPU> FindGpuByCategory(string Category)
        {
            return HWCtr.FindGpuByCategory(Category);
        }

        public IEnumerable<GPU> FindGpuByManufacturer(string Manufacturer)
        {
            return HWCtr.FindGpuByManufacturer(Manufacturer);
        }

        public IEnumerable<GPU> FindGpuByModel(string Model)
        {
            return HWCtr.FindGpuByModel(Model);
        }

        public GPU FindGPUbyId(int id)
        {
            return HWCtr.FindGPUbyId(id);
        }

        public void UpdateGPU(GPU gpu)
        {
            HWCtr.UpdateGPU(gpu);
        }

        #endregion

        #region Computer Case

        public IEnumerable<Computer_Case> FindAllComputerCases()
        {
            return HWCtr.FindAllComputerCases();
        }
        public IEnumerable<Computer_Case> FindComputerCaseByCategory(string Category)
        {
            return HWCtr.FindComputerCaseByCategory(Category);
        }

        public IEnumerable<Computer_Case> FindComputerCaseByManufacturer(string Manufacturer)
        {
            return HWCtr.FindComputerCaseByManufacturer(Manufacturer);
        }

        public Computer_Case FindCaseById(int id)
        {
            return HWCtr.FindCaseById(id);
        }

        public void UpdateComputerCase(Computer_Case Ccase)
        {
            HWCtr.UpdateCase(Ccase);
        }

        #endregion

        #endregion

        // Customer
        #region

        public void CreateCustomer(Customer customer)
        {
            customerCtr.CreateCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            customerCtr.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            customerCtr.DeleteCustomer(id);
        }

        public Customer FindCustomerById(int id)
        {
            return customerCtr.FindCustomerById(id);
        }

        public IEnumerable<Customer> FindCustomerByName(string name)
        {
            return customerCtr.FindCustomerByName(name);
        }

        public IEnumerable<Customer> FindAllCustomers()
        {
            return customerCtr.FindAllCustomers();
        }

        #endregion

        // Basket
        #region
        public void CreateBasket(Basket basket)
        {
            basketctr.CreateBasket(basket);
        }
        #endregion

    }
}
