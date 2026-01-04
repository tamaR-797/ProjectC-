using DalApi;
using DO;
using static Dal.DataSource;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        public int Create(Sale item)
        {
            foreach (var s in sales)
            {
                if (item?.SaleId == s.SaleId)
                    throw new Exception("the sale already exists");
            }
            int id = Config.getStaicValue;
            Sale sale = item with { SaleId = id };
            sales.Add(sale);
            return id;
        }
        public Sale? Read(int id)
        {
            foreach (var s in sales)
            {
                if (id == s.SaleId)
                    return s;
            }
            throw new NotImplementedException();
        }
        public List<Sale> ReadAll()
        {
            return sales;
        }
        public void Update(Sale item)
        {
            Delete(item.SaleId);
            sales.Add(item);
        }
        public void Delete(int id)
        {
            foreach (var s in sales)
            {
                if (id == s.SaleId)
                {
                    sales.Remove(s);
                    return;
                }
            }
            throw new NotImplementedException();
        }
    }
}
