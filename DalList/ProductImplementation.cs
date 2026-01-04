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
                if (item?.ProdId == p.ProdId)
                    throw new Exception("the sale already exists");
            }
            int id = Config.getStaicValue;
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
            foreach (var p in products)
            {
                if (item.ProdId == p.ProdId) {
                    products.Remove(p);
                    products.Add(item); }
                   
                return;
            }
            throw new NotImplementedException();
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

