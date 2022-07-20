

namespace Phonebook.Server.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;  
        public int ZipCode { get; set; }   
        public string pozivni { get; set; } = null!;

        public ICollection<Address> Addresses { get; set; } = null!;
    }
}
