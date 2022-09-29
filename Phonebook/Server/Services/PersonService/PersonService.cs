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
            var response = new ServiceResponse<List<Person>>();
            if (persons == null)
            {
                response.Success = false;
                response.Message = "Nema podataka";
            }
            else
            {
                response.Data = persons;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Person>>> GetPersonsbyId(int id)
        {
            var response= new ServiceResponse<List<Person>>();
            var persons = await _context.Addresses.Where(c => c.Id == id).SelectMany(c => c.Persons).ToListAsync();
            if(persons == null)
            {
                response.Success = false;
                response.Message = "Nema podataka";
            }
            else
            {
                response.Data = persons;
            }
            return response;
        }
    }
}
