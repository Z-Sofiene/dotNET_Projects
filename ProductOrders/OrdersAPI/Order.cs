namespace OrdersAPI
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate{ get; }
        public String? CustomerName { get; set; }
        public int ProductId { get; set; }
    }
}
