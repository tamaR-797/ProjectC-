
using DalApi;
using DO;
using Dal;  
using static Dal.DataSource;


namespace DalList;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {

        foreach (var p in products)
        {
            if (item.ProdId == p?.ProdId)
                throw new Exception("this id existing!");
        }
        int id = Config.getStaticValueProduct;
        Product product = item with { ProdId = id };
        products.Add(product);
        return id;
        
    }
    public Product Read(int id)
    {
        foreach (var p in products)
        {
            if (id == p.ProdId)
                return p;

        }
        throw new NotImplementedException("not existing!");
    }
    public List<Product?> ReadAll()
    {
        return products;
    }
    public void Update(Product item)
    {
        bool f = false;
        if (item == null)
            throw new Exception("Product  cannot be null.");
        foreach (var p in products)
        {
            if (item.ProdId == p?.ProdId)
            {
                f = true;
                Delete(item.ProdId);
                products.Add(item);
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
        foreach (var p in products)
        {
            if (id == p?.ProdId)
            {
                products.Remove(p);
                return;
            }
        }
        throw new NotImplementedException();

    }
}
