using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DBLayer;
using ModelLayer.Hardware;
using ModelLayer;

namespace ControlerLayer
{
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

        #endregion

        // Test method.
        public IEnumerable<CPUTestClase> FindAllCPUs2()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUTestClas.ToList();
            }
        }
    }
}
