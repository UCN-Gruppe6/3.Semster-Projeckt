using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using ModelLayer;
using System.ServiceModel;

namespace WCFServices
{
    [ServiceContract]
    interface IPcPartServise
    {
        // Vare CRUD
        #region

        // CPU
        [OperationContract]
        void CreateCPU(CPU cpu);
        [OperationContract]
        void UpdateCPU(CPU cpu);
        [OperationContract]
        void DeleteCPU(int id);

        #endregion

        // Hardware
        #region

        // CPU START
        [OperationContract]
        IEnumerable<CPU> FindCPUsByBrand(string Brand);
        [OperationContract]
        IEnumerable<CPU> FindCPUsByCategory(string Category);
        [OperationContract]
        IEnumerable<CPU> FindAllCPUs();
        // CPU END

        // Storage START
        [OperationContract]
        IEnumerable<Storage> FindStorageByManufacturer(string Manufacturer);
        [OperationContract]
        IEnumerable<Storage> FindStorageByCategory(string Category);
        [OperationContract]
        IEnumerable<Storage> FindAllStorage();
        // Storage END

        // RAM START
        [OperationContract]
        IEnumerable<RAM> FindRamByManufacturer(string Manufacturer);
        [OperationContract]
        IEnumerable<RAM> FindRamByCategory(string Category);
        [OperationContract]
        IEnumerable<RAM> FindAllRam();
        // RAM END

        // Motherboard START
        [OperationContract]
        IEnumerable<Motherboard> FindMotherboardByManufacturer(string Manufacturer);
        [OperationContract]
        IEnumerable<Motherboard> FindMotherboardByCategory(string Category);
        [OperationContract]
        IEnumerable<Motherboard> FindAllMotherboard();
        // Motherboard END 

        // GPU START
        [OperationContract]
        IEnumerable<GPU> FindGpuByManufacturer(string Manufacturer);
        [OperationContract]
        IEnumerable<GPU> FindGpuByModel(string Model);
        [OperationContract]
        IEnumerable<GPU> FindGpuByCategory(String Category);
        [OperationContract]
        IEnumerable<GPU> FindAllGpus();
        // GPU END

        // Computer Case START
        [OperationContract]
        IEnumerable<Computer_Case> FindComputerCaseByManufacturer(string Manufacturer);
        [OperationContract]
        IEnumerable<Computer_Case> FindComputerCaseByCategory(string Category);
        [OperationContract]
        IEnumerable<Computer_Case> FindAllComputerCases();
        // Computer Case END 
        #endregion

        // Customer
        #region

        [OperationContract]
        void CreateCustomer(Customer customer);
        [OperationContract]
        void UpdateCustomer(Customer customer);
        [OperationContract]
        void DeleteCustomer(int id);
        [OperationContract]
        Customer FindCustomerById(int id);
        [OperationContract]
        IEnumerable<Customer> FindCustomerByName(string name);
        [OperationContract]
        IEnumerable<Customer> FindAllCustomers();

        #endregion

        [OperationContract]
        Socket FindSocket(int id);

        //[OperationContract]
        //void StockCpuADD(string modelNumber, int numberToAdd);
    }
}
