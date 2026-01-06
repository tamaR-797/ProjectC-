using DalApi;
using DO;
using static Dal.DataSource;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        public int Create(Customer item)
        {
            foreach (var c in customers)
            {
                if (item.CustId == c?.CustId)
                    throw new Exception("this id exsisting!");
            }
            int id = Config.getStaticValueCustomer;
            Customer cust = item with { CustId = id };
            customers.Add(cust);
            return id;
        }

        public Customer? Read(int id)
        {
            foreach (var c in customers)
            {
                if (id == c?.CustId)
                    return c;
            }
            throw new NotImplementedException("not existing!");
        }

        public List<Customer?> ReadAll()
        {
            return customers;
        }

        public void Update(Customer item)
        {bool f=false;
            if (item == null)
                throw new Exception("Product  cannot be null.");
            foreach (var c in customers)
            {
                if (item.CustId == c?.CustId)
                {
                    f = true;
                    Delete(item.CustId);
                    customers.Add(item);
                    return;
                }
            }
            if (!f)
            {
                throw new Exception("not id existing!");
            }
        }

        public void Delete(int id)
        {
            foreach (var c in customers)
            {
                if (id == c?.CustId)
                {
                    customers.Remove(c);
                    return;
                }
            }
            throw new NotImplementedException();
        }
    }
}

