namespace DesignPattern.Console.Builder
{
    public class ProductDirector
    {
        private readonly ProductBuilder _productBuilder;

        public ProductDirector(ProductBuilder productBuilder)
        {
            _productBuilder = productBuilder;
        }

        public Product BuildProduct(Product product)
        {
            _productBuilder.Set(product);
            _productBuilder.ApplyDiscount();
            return _productBuilder.GetProduct();
        }
    }
}
