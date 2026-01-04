using DalApi;
using DO;
using static Dal.DataSource;
namespace Dal
{
    public class CustomerImplementation : ICustomer
    {
        public int Create(Customer item)
        {
            foreach (var c in customerss)
            {
                if (item?.CustId == c.CustId)
                    throw new Exception("the sale already exists");
            }
            int id = Config.getStaicValue;
            Customer customer = item with { CustId = id };
            customerss.Add(customer);
            return id;
        }

        public Customer? Read(int id)
        {
            foreach (var c in customerss)
            {
                if (id == c.CustId)
                    return c;
            }
            throw new NotImplementedException();
        }

        public List<Customer> ReadAll()
        {
            return customerss;
        }

        public void Update(Customer item)
        {
            foreach (var c in customerss)
            {
                if (item.CustId == c.CustId)
                {
                    customerss.Remove(c);
                    customerss.Add(item);
                }

                return;
            }
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            foreach (var c in customerss)
            {
                if (id == c.CustId)
                {
                    customerss.Remove(c);
                    return;
                }
            }
            throw new NotImplementedException();
        }
    }
}
