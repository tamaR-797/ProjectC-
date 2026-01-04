using DO;

namespace Dal;
internal static class DataSource
{

    internal static List<Product?> products = new List<Product?>();
    internal static List<Sale?> sales = new List<Sale?>();
    internal static List<Customer?> customerss = new List<Customer?>();
    internal static class Config
    {
        internal const int min = 100;
        private static int staticValue = min;
        public static int getStaicValue { get{ return staticValue++; } }
    }
}

