

namespace DO
{
   public  record Sale(int SaleId,int ProdId,int ?QuantitySale=null, double ?SalePrice=null,bool ?IsClub=null,DateTime ?StartDate=null,DateTime ?EndDate=null)
    {
        public Sale() : this(0,0)
        {
        }
    }
}
