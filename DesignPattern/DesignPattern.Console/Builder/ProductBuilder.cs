namespace DesignPattern.Console.Builder
{
    public abstract class ProductBuilder
    {
        public abstract void Set(Product product);
        public abstract void ApplyDiscount();
        public abstract Product GetProduct();
    }
}
