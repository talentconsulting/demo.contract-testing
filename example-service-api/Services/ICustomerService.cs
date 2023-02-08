using example_service_api.Models;

namespace example_service_api.Services
{
    public interface ICustomerService
    {
        Task AddCustomer(Customer customer);
        Task DeleteCustomer(string id);
        Task<Customer?> GetCustomer(string id);
        Task<List<Customer>> GetCustomers();
    }
}

