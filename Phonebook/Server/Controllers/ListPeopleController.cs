using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phonebook.Server.Data;
using Phonebook.Server.Models;
using Phonebook.Server.Services.PersonServices;
using Phonebook.Shared;

namespace Phonebook.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListPeopleController : ControllerBase
    {

        private readonly IPersonService _personService;

        public ListPeopleController(IPersonService personService)
        {

            _personService=personService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPersons()
        {
            var response = await _personService.GetPersons();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPersonsbyId(int id)
        {
            var response=await _personService.GetPersonsbyId(id);   
            return Ok(response);
        }
    };
}
