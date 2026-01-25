//למימוש עם linq
using DalApi;
using DO;
using Dal;
using static Dal.DataSource;
using System.Linq;

namespace DalList
{
    internal class SaleImplementation : ISale
    {
        public int Create(Sale item)
        {
            // use Enumerable.Any to check for existing id
            if (sales.Any(s => item.SaleId == s?.SaleId))
                throw new IdAlreadyExistsException($"{item.SaleId}");

            int id = Config.getStaticValueSale;
            Sale sale = item with { SaleId = id };
            sales.Add(sale);
            return id;
        }

        public Sale? Read(int id)
        {
            // method-syntax LINQ: returns first matching sale or null
            var sale = sales.FirstOrDefault(s => s?.SaleId == id);

            if (sale == null)
                throw new IdNotFoundException($"{id}");
            return sale;
        }

        public List<Sale?> ReadAll()
        {
            // Enumerable.ToList to return a copy
            return sales.ToList();
        }

        public void Update(Sale item)
        {
            if (item == null)
                throw new NullItemException("Sale cannot be null.");

            // find index with LINQ (Select with index) and replace in-place to preserve order
            var entry = sales
                .Select((s, i) => new { Sale = s, Index = i })
                .FirstOrDefault(x => x.Sale?.SaleId == item.SaleId);

            if (entry != null)
            {
                sales[entry.Index] = item;
            }
            else
            {
                throw new IdNotFoundException($"{item.SaleId}");
            }
        }

        public void Delete(int id)
        {
            // use List.RemoveAll with predicate (concise) — returns number of removed items
            var removedCount = sales.RemoveAll(s => s?.SaleId == id);
            if (removedCount == 0)
                throw new NullItemException("");
        }
    }
}


//using DalApi;
//using DO;
//using Dal;
//using static Dal.DataSource;

//namespace DalList
//{
//    internal class SaleImplementation :ISale
//    {


//        public int Create(Sale item)
//        {
//            foreach (var c in sales)
//            {
//                if (item.SaleId == c?.SaleId)
//                    throw new Exception("this id existing!");
//            }
//            int id = Config.getStaticValueSale;
//            Sale sale = item with { SaleId = id };
//            sales.Add(sale);
//            return id;
//        }

//        public Sale? Read(int id)
//        {
//            foreach (var c in sales)
//            {
//                if (id == c?.SaleId)
//                    return c;
//            }
//            throw new NotImplementedException("not existing!");
//        }

//        public List<Sale?> ReadAll()
//        {
//            return sales;
//        }

//        public void Update(Sale item)
//        {
//            bool f = false;
//            if (item == null)
//                throw new Exception("Product  cannot be null.");
//            foreach (var c in sales)
//            {
//                if (item.SaleId == c?.SaleId)
//                {
//                    f=true;
//                    Delete(item.SaleId);
//                    sales.Add(item);
//                    return;
//                }    
//            }
//            if (!f)
//            {
//                throw new Exception("not id existing!");
//            }

//        }

//        public void Delete(int id)
//        {
//            foreach (var c in sales)
//            {
//                if (id == c?.SaleId)
//                {
//                    sales.Remove(c);
//                    return;
//                }
//            }
//            throw new NotImplementedException();
//        }
//    }
//}

