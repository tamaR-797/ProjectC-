
using System.Runtime.CompilerServices;

namespace DO
{
    public record Product(int ProdId, string? ProdName=null, Categories? category=null, double? ProdPrice=null, int? QuantityInStock = null)
    {
        public Product() : this(0)
        {
        }
    }

}
