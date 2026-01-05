using DO;
using DalApi;
using Dal;



namespace DalTest {

public static class Initalization
{
        private static IDal? s_dal;
    private static void createSale(ISale si)
    {
        si.Create(new Sale { EndDate = DateTime.Now, IsClub = true, ProdId = 5, QuantitySale = 33, SaleId = 1, SalePrice = 100, StartDate = null });
    }
    private static void createCustomer(ICustomer ci)
    {
        ci.Create(new Customer { CustAddress = "Netivot Shalom 7", CustId = 1, CustName = "Naama Veig", CustPhone = "0533110130" });
    }
    private static void createProduct(IProduct pi)
    {

        pi.Create(new Product { category = Categories.DRESSES, ProdId = 5, ProdName = "gfg", ProdPrice = 100, QuantityInStock = 100 });
    }
    public static void initialize(IDal dal)
    {
        s_dal = dal;
        createSale(s_dal.Sale);
        createCustomer(s_dal.Customer);
        createProduct(s_dal.Product);
    }
}
}
