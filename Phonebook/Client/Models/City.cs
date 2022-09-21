

namespace Phonebook.Server.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;  
        public int ZipCode { get; set; }   
        public string Pozivni { get; set; } = null!;

        public List<Address> Addresses { get; set; } = null!;
    }
}
