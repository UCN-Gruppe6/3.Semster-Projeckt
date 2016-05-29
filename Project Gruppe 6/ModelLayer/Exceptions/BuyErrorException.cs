using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Exceptions
{
    public class BuyErrorException : Exception
    {
        public BuyErrorException(string message) : base(message)
        {

        }
    }
}
