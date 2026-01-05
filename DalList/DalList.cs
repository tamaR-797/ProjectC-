using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalList;

namespace Dal;

    public class DalList:IDal
    {
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
        public ICustomer Customer => new CustomerImplementation();

    }

