using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.Hardware;
using ControlerLayer;

namespace WCFServices 
{
    public class PcPartServise : IPcPartServise
    {

        private HardwererCtr HWCtr = new HardwererCtr();

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

        #endregion
    }
}
