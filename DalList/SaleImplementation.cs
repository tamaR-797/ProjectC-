using DalApi;
using DO;
using static Dal.DataSource;

namespace Dal
{
    public class SaleImplementation :ISale
    {
    

        public int Create(Sale item)
        {

            foreach (var s in sales)
            {
                if (item?.SaleId == s.SaleId)
                    throw new Exception();
            }
            int id = Config.getStaticValue;
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
            throw new Exception("not found");
            throw new NotImplementedException();
        }
        public List<Sale> ReadAll()
        {       if(sales!=null)
                return sales;
            throw new NotImplementedException();
        }
        public void Update(Sale item)
        {
            foreach (var s in sales)
            {
                if (item?.SaleId == s.SaleId)
                {
                    sales.Remove(s);
                    sales.Add(item);
                    return;
                }

            }
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

