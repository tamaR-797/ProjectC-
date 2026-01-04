using DO;

namespace Dal;
internal static class DataSource
{

    internal static List<Sale?> sales = new List<Sale?>();
    internal static List<Customer?> customers = new List<Customer?>();
    internal static List<Product?> products = new List<Product?>();
    internal static class Config 
    {
        internal const int min = 100;
        private static int staticValue = min;
        public static int getStaticValue { get { return staticValue++; } }

    }
}
