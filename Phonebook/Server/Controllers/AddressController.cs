using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Server.Services.AddressService;
using Phonebook.Server.Services;
using Phonebook.Shared;
using Phonebook.Server.Models;

namespace Phonebook.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;    
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Address>>>> GetAddressesbyId(int id)
        {
            var response = await _addressService.GetAddressesbyId(id);
            return Ok(response);    
        }
    }
}
