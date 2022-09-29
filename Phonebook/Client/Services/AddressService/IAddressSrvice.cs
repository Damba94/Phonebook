using Phonebook.Server.Models;
using Phonebook.Shared;

namespace Phonebook.Client.Services.AddressService

{
    public interface IAddressSrvice
    {
        List<Address>Addresses {get;set;}
        Task<ServiceResponse<List<Address>>> GetAddressesbyId(int id);
    }
}
