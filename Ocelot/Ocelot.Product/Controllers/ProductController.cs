using Microsoft.AspNetCore.Mvc;
using Ocelot.Product.Repositories;

namespace Ocelot.Product.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository customerRepository)
    {
        _productRepository = customerRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Models.Product>>> GetAllCustomers()
    {
        return await _productRepository.GetAllProducts();
    }
}