using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phonebook.Server.Data;
using Phonebook.Server.Models;
using Phonebook.Shared;

namespace Phonebook.Server.Services.AddressService
{
    public class AddressService : IAddressService
    {

        private readonly PhonebookContext _context;
        public AddressService(PhonebookContext context)
        {
            _context=context;
        }


        public async Task<ServiceResponse<List<Address>>> GetAddressesbyId(int id)
        {
            var response=new ServiceResponse<List<Address>>();
            var adresses = await _context.Persons.Where(p => p.Id == id).SelectMany(p => p.Addresses).ToListAsync();
            if (adresses == null)
            {
                response.Success = false;
                response.Message = "Nema podataka";
            }
            else
            {
                response.Data = adresses;
            }
            return response;    
        }


    }
}
