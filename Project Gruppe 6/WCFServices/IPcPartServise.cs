using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using System.ServiceModel;

namespace WCFServices
{
    [ServiceContract]
    interface IPcPartServise
    {
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

        #endregion

    }
}
