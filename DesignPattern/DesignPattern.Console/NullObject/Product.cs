namespace DesignPattern.Console.NullObject
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set;}
        public decimal? MinimumPrice { get;}
        public decimal? MaximumPrice { get; set;}
        public decimal? MinimumAmount { get; }
        public decimal? MaximumAmount { get; set;}
    }
}
