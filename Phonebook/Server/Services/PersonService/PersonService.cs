using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phonebook.Server.Data;
using Phonebook.Server.Models;
using Phonebook.Shared;


namespace Phonebook.Server.Services.PersonServices
{
    public class PersonService : IPersonService
    {
        private readonly PhonebookContext _context;



        public PersonService(PhonebookContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Person>>> GetPersons()
        {
            var persons = await _context.Persons.ToListAsync();
            var responses = new ServiceResponse<List<Person>>
            {
               Data=persons
            };
            return responses;
        }

 
    }
}
