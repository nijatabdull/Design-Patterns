using DesignPattern.Console.NullObject;

ProductRepository productRepository = new ProductRepository();

IEntity entity =  productRepository.First(-1);


Console.WriteLine(entity.Id);

Console.WriteLine();