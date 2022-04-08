using Microsoft.AspNetCore.Mvc;
using Ocelot.Customer.Repository;

namespace Ocelot.Customer.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Models.Customer>>> GetAllCustomers()
    {
        return await _customerRepository.GetAllCustomers();
    }
}