using Phonebook.Server.Models;
using Phonebook.Shared;
using System.Net.Http.Json;

namespace Phonebook.Client.Services.AddressService
{
    public class AddressService : IAddressSrvice
    {
        private readonly HttpClient _http;
        public AddressService(HttpClient http)
        {
            _http = http;
        }

        public List<Address> Addresses { get ; set; }

        public async Task<ServiceResponse<List<Address>>> GetAddressesbyId(int id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Address>>>($"api/Address/{id}");
            return result;
        }
    }
}
