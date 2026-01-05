using DO;

namespace Dal;
internal static class DataSource
{

    internal static List<Sale?> sales = new List<Sale?>();
    internal static List<Customer?> customers = new List<Customer?>();
    internal static List<Product?> products = new List<Product?>();
    
    
    
    internal static class Config 
    {
        internal const int minSale = 100;
        private static int staticValueSale = minSale;
        public static int getStaticValueSale { get { return staticValueSale++; } }

        internal const int minCustomer = 1000;
        private static int staticValueCustomer = minCustomer;
        public static int getStaticValueCustomer { get { return staticValueCustomer++; } }

        internal const int minProduct = 10000;
        private static int staticValueProduct = minProduct;
        public static int getStaticValueProduct { get { return staticValueProduct++; } }
    }
}
