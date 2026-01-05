using DalApi;
using DO;
using Dal;
using static Dal.DataSource;

namespace DalList
{
    internal class SaleImplementation :ISale
    {


        public int Create(Sale item)
        {
            foreach (var c in sales)
            {
                if (item.SaleId == c?.SaleId)
                    throw new Exception();
            }
            int id = Config.getStaticValueSale;
            Sale sale = item with { SaleId = id };
            sales.Add(sale);
            return id;
        }

        public Sale? Read(int id)
        {
            foreach (var c in sales)
            {
                if (id == c?.SaleId)
                    return c;
            }
            throw new NotImplementedException();
        }

        public List<Sale?> ReadAll()
        {
            return sales;
        }

        public void Update(Sale item)
        {
            if (item == null)
                throw new Exception("Product  cannot be null.");
            Delete(item.SaleId);
            sales.Add(item);
        }

        public void Delete(int id)
        {
            foreach (var c in sales)
            {
                if (id == c.SaleId)
                {
                    sales.Remove(c);
                    return;
                }
            }
            throw new NotImplementedException();
        }
    }
}

