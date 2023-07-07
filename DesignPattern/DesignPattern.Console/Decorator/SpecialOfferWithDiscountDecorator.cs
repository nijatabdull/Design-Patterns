namespace DesignPattern.Console.Decorator
{
    public class SpecialOfferWithDiscountDecorator : Decorator
    {
        public SpecialOfferWithDiscountDecorator(CarBase carBase) : base(carBase)
        {
           
        }

        public override string Model { get ; set ; }
        public override decimal Price { get 
            {
                return base._carBase.Price * 0.9m;
            } set { } }
    }
}
