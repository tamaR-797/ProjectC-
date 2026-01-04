


namespace DalApi
{
    public interface IDal
    {
        IProduct Product { get; }
        ICustomer Customer { get; }
        ISale sale {  get; }
    }
}
