

namespace Phonebook.Server.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; } = null!;
        public int ZipCode { get; set; }    
        public int PhoneNumber { get; set; }
        

      
        public List<Person> Persons { get; set; }=null!; 

        public City City { get; set; } = null!;



    }
}
