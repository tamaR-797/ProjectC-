using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
   public  record Customer(int CustId=0, string ?CustName=null,string ?CustAddress=null,string ?CustPhone=null)
    {
public Customer() : this(0,null,null,null)
        {
        }
    }
}
