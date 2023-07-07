namespace DesignPattern.Console.Adapter
{
    public class ProductManager 
    {
        private readonly ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger= logger;
        }

        public void Save()
        {
            //business logic
            _logger.Log("Data saved");
        }
    }
}
