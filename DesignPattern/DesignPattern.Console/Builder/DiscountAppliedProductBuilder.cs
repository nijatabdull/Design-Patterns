namespace DesignPattern.Console.Builder
{
    public class DiscountAppliedProductBuilder : ProductBuilder
    {
        private Product _product;
        public override void ApplyDiscount()
        {
            _product.PriceApplied = true;
        }

        public override Product GetProduct()
        {
            return _product;
        }

        public override void Set(Product product)
        {
            _product= product;
        }
    }
}
