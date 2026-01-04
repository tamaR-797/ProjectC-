
using DalApi;
using DO;
using static Dal.DataSource;
namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        public int Create(Product item)
        {

            foreach (var p in products)
            {
                if (item.ProdId == p?.ProdId)
                    throw new Exception();
            }
            int id = Config.getStaticValue;
            Product product = item with { ProdId = id };
            products.Add(product);
            return id;

        }
        public Product? Read(int id)
        {
            foreach (var p in products)
            {
                if (id == p.ProdId)
                    return p;

            }
            throw new NotImplementedException();
        }
        public List<Product> ReadAll()
        {
            return products;
        }
        public void Update(Product item)
        {
            if (item.ProdId == null)
                throw new Exception("Product ID cannot be null.");
            Delete(item.ProdId.Value);
            products.Add(item);
        }
        public void Delete(int id)
        {
            foreach (var p in products)
            {
                if (id == p.ProdId)
                {
                    products.Remove(p);
                    return;
                }
            }
            throw new NotImplementedException();

        }
    }
}
