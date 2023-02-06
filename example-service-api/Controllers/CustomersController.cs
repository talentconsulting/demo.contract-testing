using example_service_api.Models;
using example_service_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace example_service_api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ICustomerService customerService, ILogger<CustomersController> logger)
    {
        _customerService = customerService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<Customer>> GetAllCustomers()
    {
        return await _customerService.GetCustomers();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetCustomer(string id)
    {
        var customer = await _customerService.GetCustomer(id);

        if (customer != null)
        {
            return Ok(customer);
        }

        return NotFound($"Customer id {id} not found");
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer(Customer customer)
    {
        if (ModelState.IsValid) 
        {
            customer.Id = Guid.NewGuid().ToString();

            await _customerService.AddCustomer(customer);

            return Created(new Uri($"api/customers/{customer.Id}", UriKind.Relative), customer);
        }

        return BadRequest(ModelState);
    }
}

