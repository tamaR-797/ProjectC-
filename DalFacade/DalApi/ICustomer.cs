using DO;


namespace DalApi
{
    public  interface ICustomer:ICrud<Customer>
    {

        int Create(Customer c);
        Customer Read(int id);
        List<Customer> ReadAll();
        void Update(Customer c);
        void Delete(int id);
    }
}
