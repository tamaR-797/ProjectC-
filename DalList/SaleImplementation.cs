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
                    throw new Exception("this id existing!");
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
            throw new NotImplementedException("not existing!");
        }

        public List<Sale?> ReadAll()
        {
            return sales;
        }

        public void Update(Sale item)
        {
            bool f = false;
            if (item == null)
                throw new Exception("Product  cannot be null.");
            foreach (var c in sales)
            {
                if (item.SaleId == c?.SaleId)
                {
                    f=true;
                    Delete(item.SaleId);
                    sales.Add(item);
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
            foreach (var c in sales)
            {
                if (id == c?.SaleId)
                {
                    sales.Remove(c);
                    return;
                }
            }
            throw new NotImplementedException();
        }
    }
}

