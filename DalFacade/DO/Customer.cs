using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
     record Customer(string CustId, string CustName,string CustAddress,string CustPhone)
    {
        Constructor = this;
    }
}
