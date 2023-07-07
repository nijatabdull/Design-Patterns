namespace DesignPattern.Console.Builder
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool PriceApplied { get; set; }
    }
}
