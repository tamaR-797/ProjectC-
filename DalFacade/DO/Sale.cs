using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
     record Sale(int SaleId,int ProdId,int QuantitySale, double SalePrice,bool IsClub,DateTime StartDate,DateTime EndDate)
    {
       
    }
}
