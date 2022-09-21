using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phonebook.Server.Data;
using Phonebook.Server.Models;

namespace Phonebook.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListPeopleController : ControllerBase
    {
        private readonly PhonebookContext _context;

        public ListPeopleController(PhonebookContext context)
        {
            _context=context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeoples()
        {
            var people = await _context.Persons.ToListAsync();
            return Ok(people);
        }
    };
}
