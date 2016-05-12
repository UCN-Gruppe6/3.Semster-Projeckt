using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.Hardware;
using ControlLayer;


namespace WCFServices 
{
    public class PcPartServise : IPcPartServise
    {

        private HardwererCtr HWCtr = new HardwererCtr();
        private CustomerCtr customerCtr = new CustomerCtr();
        private ProductCtr proCtr = new ProductCtr();

        // Vare CRUD
        #region

        //CPU 
        public void CreateCPU(CPU cpu)
        {
            proCtr.CreateCPU(cpu);
        }

        public void UpdateCPU(CPU cpu)
        {
            proCtr.UpdateCPU(cpu);
        }

        public void DeleteCPU(int id)
        {
            proCtr.DeleteCPU(id);
        }
        #endregion

        // Hardware
        #region

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
        // CPU END
       
        // Storage START

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

        // Storage END
        
        // RAM START
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

        // RAM END 

        // Motherboard START
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
        // Motherboard END 

        // GPU START 
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
        // GPU END 

        // Computer Case START

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

        // Computer Case END 
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

        public Socket FindSocket(int id)
        {
            return HWCtr.FindSocket(id);
        }


    }
}
