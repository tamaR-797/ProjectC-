using DO;

namespace DalApi
{
    public  interface IProduct:ICrud<Product>
    {
        int Create(Product p);
        Product Read(int id);
        List<Product>  ReadAll();
        void Update(Product p);
        void Delete(int id);
    }
}
