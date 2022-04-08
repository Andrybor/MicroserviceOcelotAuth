namespace Ocelot.Product.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly List<Models.Product> _products = new ();

    public ProductRepository()
    {
        _products.Add(new Models.Product
        {
            Id = Guid.NewGuid(),
            Code = "P0001",
            Name = "Lenovo Laptop",
            Quantity_In_Stock = 15,
            Unit_Price = 125000
        });

        _products.Add(new Models.Product
        {
            Id = Guid.NewGuid(),
            Code = "P0002",
            Name = "DELL Laptop",
            Quantity_In_Stock = 25,
            Unit_Price = 135000
        });

        _products.Add(new Models.Product
        {
            Id = Guid.NewGuid(),
            Code = "P0003",
            Name = "HP Laptop",
            Quantity_In_Stock = 20,
            Unit_Price = 115000
        });
    }
    
    public Task<List<Models.Product>> GetAllProducts()
    {
        return Task.FromResult(_products);
    }
}