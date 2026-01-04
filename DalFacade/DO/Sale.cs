

namespace DO
{
   public  record Sale(int SaleId=0,int ProdId=0,int QuantitySale=0, double SalePrice=0,bool IsClub=true,DateTime ?StartDate=null,DateTime ?EndDate=null)
    {
       
    }
}
