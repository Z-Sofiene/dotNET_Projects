namespace ProductsAPI
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }=string.Empty;
        public double Price { get; set; }

        public int StockQte { get; set; }
    }
}
