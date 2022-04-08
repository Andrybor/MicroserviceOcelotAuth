namespace Ocelot.Customer.Repository;

public class CustomerRepository : ICustomerRepository
{
    private readonly List<Models.Customer> customers = new();   
    
    public CustomerRepository()
    {
        customers.Add(new Models.Customer()
        {
            Id = Guid.NewGuid(),
            FirstName = "Andrii",
            LastName = "Borysenko",
            EmailAddress = "andryborisenko1999@ukr.net"
        });
        
        customers.Add(new Models.Customer()
        {
            Id = Guid.NewGuid(),
            FirstName = "Sergii",
            LastName = "Khomchenko",
            EmailAddress = "sergiikhomchenko1999@ukr.net"
        });
    }
    
    public Task<List<Models.Customer>> GetAllCustomers()
    {
        return Task.FromResult(customers);
    }
}