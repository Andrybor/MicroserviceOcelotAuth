namespace Ocelot.Product.Repositories;

public interface IProductRepository
{
    public Task<List<Models.Product>> GetAllProducts();
}