namespace Ocelot.Customer.Repository;

public interface ICustomerRepository
{
    public Task<List<Models.Customer>> GetAllCustomers();
}