using Microsoft.AspNetCore.Mvc;
using MiniBank.Models;
using MiniBank.Services.Interfaces;

namespace MiniBank.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var result = await _customerService.GetCustomers();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllCustomers([FromRoute] int id)
        {
            var result = await _customerService.GetCustomer(id);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer model)
        {
            await _customerService.AddCustomer(model);
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] int id)
        {
            await _customerService.DeleteCustomer(id);
            return Created();
        }


        [HttpPut]
        public async Task<IActionResult> UpdateCustomer([FromBody] Customer model)
        {
            await _customerService.UpdateCustomer(model);
            return Created();
        }
    }
}
