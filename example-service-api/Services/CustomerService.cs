using example_service_api.Models;

namespace example_service_api.Services
{
    public class CustomerService : ICustomerService
	{
		private List<Customer> _customers = new List<Customer>();

		public Task AddCustomer(Customer customer)
		{
			if (_customers.Any<Customer>(c => c.Id == customer.Id))
			{
				throw new Exception("Bad request");
			}

			_customers.Add(customer);

			return Task.FromResult(true);
		}

        public Task<List<Customer>> GetCustomers()
        {
            return Task.FromResult(_customers);
        }

		public Task<Customer?> GetCustomer(string id)
		{
			return Task.FromResult(_customers.FirstOrDefault<Customer>(c => c.Id == id));
		}
    }
}

