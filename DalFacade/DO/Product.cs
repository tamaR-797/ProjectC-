
using System.Runtime.CompilerServices;

namespace DO
{
    public record Product(int? ProdId, string? ProdName, Categories? category, double? ProdPrice, int? QuantityInStock)
    {
        public Product() : this(0, "", Categories.DRESSES, 0, 0)
        {
        }
    }

}
