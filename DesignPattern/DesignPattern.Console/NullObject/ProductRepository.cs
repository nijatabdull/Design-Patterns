namespace DesignPattern.Console.NullObject
{
    public class ProductRepository
    {
        public IEntity First(int id)
        {
            IEntity entity = null;

            if(id > 0)
            {
                entity = new Product()
                {
                    Id = id,
                    Amount= 6,
                };
            }

            return entity;
        }
    }
}
