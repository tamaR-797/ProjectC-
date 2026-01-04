
namespace DO
{
    public record Product(int ProdId = 0, string? ProdName = null, Categories? category = Categories.DRESSES, double ?ProdPrice = 0, int ?QuantityInStock = 0)
    {
        public Product() : this(0,"") { }

    }
}
