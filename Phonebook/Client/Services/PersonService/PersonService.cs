using Phonebook.Server.Models;
using Phonebook.Shared;
using System.Net.Http.Json;

namespace Phonebook.Client.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _http;
        public PersonService(HttpClient http)
        {
            _http = http;   
        }
        
        public List<Person> Persons { get ; set ; }=new List<Person>(); 

        public async Task GetPersons()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Person>>>("api/ListPeople");
            Persons = result.Data;

        }
    }
}
