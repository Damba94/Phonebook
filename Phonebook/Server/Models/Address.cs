

namespace Phonebook.Server.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetName { get; set; } = null!;
        public int ZipCode { get; set; }    
        public int PhoneNumber { get; set; }
        

        public string PersonId { get; set; } = null!;
        public ICollection<Person> Persons { get; set; }=null!; 

        public City City { get; set; } = null!;



    }
}
