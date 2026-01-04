using DalApi;
using DO;
using Dal;
using System;

namespace DalTest
{
    public class Initialization
    {
        private static IDal? s_dal;

        private static void createSale()
        {
           SaleImplementation si= new SaleImplementation();
            si.create(new Sale { SaleId = 100, ProdId = 100, Price = 10, Date = DateTime.Now });
        }
    }
}
