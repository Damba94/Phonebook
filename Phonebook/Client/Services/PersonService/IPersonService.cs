using Phonebook.Server.Models;

namespace Phonebook.Client.Services.PersonService
{
    public interface IPersonService
    {
        List<Person> Persons { get; set; }
        Task GetPersons();
    }
}
