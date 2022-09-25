using Phonebook.Server.Models;


using Phonebook.Shared;

namespace Phonebook.Server.Services.AddressService
{
    public interface IAddressService
    {
        //Task<ServiceResponse<List<Address>>> GetAddresses();
        Task<ServiceResponse<List<Address>>> GetAddressesbyId(int id);
    }
}

